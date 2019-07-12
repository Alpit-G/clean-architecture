using System.Threading.Tasks;
using HumanitarianAssistance.Application.Infrastructure;
using HumanitarianAssistance.Persistence;
using MediatR;

namespace HumanitarianAssistance.Application.Accounting.Commands.Create
{
    
    public class AddExchangeRateCommandHandler: IRequestHandler<AddExchangeRateCommand, ApiResponse>
    {
        private HumanitarianAssistanceDbContext _dbContext;

        public AddExchangeRateCommandHandler(HumanitarianAssistanceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ApiResponse> Handle(AddExchangeRateCommand exchangeRateModel, string userId)
        {
            ApiResponse response = new ApiResponse();

            using (IDbContextTransaction tran = _dbContext.Database .BeginTransaction())
            {
                try
                {
                    if (exchangeRateModel.Any())
                    {


                        List<ExchangeRateDetail> exchangeRateDetails = new List<ExchangeRateDetail>();

                        var exchangeRateDates = _uow.GetDbContext().ExchangeRateVerifications.Where(x => x.IsDeleted == false && x.Date.Date == exchangeRateModel.FirstOrDefault().Date.Date).ToList();
                        List<CurrencyDetails> currencyDetails = _uow.GetDbContext().CurrencyDetails.Where(x => x.IsDeleted == false).ToList();

                        if (exchangeRateDates.Any())
                        {
                            throw new Exception("Exchange rate already exists for the selected date");

                        }

                        GetSystemGeneratedExchangeRates(exchangeRateModel, ref exchangeRateDetails, currencyDetails, userId);

                        List<int> OfficeIds = await _uow.GetDbContext().OfficeDetail.Where(x => x.IsDeleted == false).Select(x => x.OfficeId).ToListAsync();

                        List<ExchangeRateDetail> exchangeRatesForAllOffices = new List<ExchangeRateDetail>();

                        foreach (int officeId in OfficeIds)
                        {
                            foreach (ExchangeRateDetail item in exchangeRateDetails)
                            {
                                ExchangeRateDetail exchangeRateDetail = new ExchangeRateDetail();
                                exchangeRateDetail.CreatedById = item.CreatedById;
                                exchangeRateDetail.CreatedDate = item.CreatedDate;
                                exchangeRateDetail.Date = item.Date;
                                exchangeRateDetail.FromCurrency = item.FromCurrency;
                                exchangeRateDetail.ToCurrency = item.ToCurrency;
                                exchangeRateDetail.IsDeleted = item.IsDeleted;
                                exchangeRateDetail.OfficeId = officeId;
                                exchangeRateDetail.Rate = item.Rate;

                                exchangeRatesForAllOffices.Add(exchangeRateDetail);

                            }
                            exchangeRatesForAllOffices.AddRange(exchangeRateDetails);
                        }

                        _uow.GetDbContext().ExchangeRateDetail.AddRange(exchangeRatesForAllOffices);
                        _uow.Save();

                        ExchangeRateVerification exchangeRateVerification = new ExchangeRateVerification();
                        exchangeRateVerification.IsDeleted = false;
                        exchangeRateVerification.CreatedById = userId;
                        exchangeRateVerification.CreatedDate = DateTime.UtcNow;
                        exchangeRateVerification.Date = exchangeRateModel.FirstOrDefault().Date;
                        exchangeRateVerification.IsVerified = false;

                        _uow.GetDbContext().ExchangeRateVerifications.Add(exchangeRateVerification);
                        _uow.GetDbContext().SaveChanges();

                        response.StatusCode = StaticResource.successStatusCode;
                        response.Message = "Exchange rates generated successfully!!!";
                        tran.Commit();
                    }
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    response.StatusCode = StaticResource.failStatusCode;
                    response.Message = StaticResource.SomethingWrong + ex.Message;
                }
            }

           
            return response;
        }
        
    }
}