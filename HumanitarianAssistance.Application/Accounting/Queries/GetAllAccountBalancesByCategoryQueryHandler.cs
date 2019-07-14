using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HumanitarianAssistance.Application.Accounting.Models;
using HumanitarianAssistance.Application.CommonFunctions;
using HumanitarianAssistance.Application.Infrastructure;
using HumanitarianAssistance.Common.Enums;
using HumanitarianAssistance.Common.Helpers;
using HumanitarianAssistance.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace HumanitarianAssistance.Application.Accounting.Queries
{
    public class GetAllAccountBalancesByCategoryQueryHandler: IRequestHandler<GetAllAccountBalancesByCategoryQuery, ApiResponse>
    {
        private HumanitarianAssistanceDbContext _dbContext;
        
        public GetAllAccountBalancesByCategoryQueryHandler(HumanitarianAssistanceDbContext dbContext)
        {
            _dbContext= dbContext;
        }

        public async Task<ApiResponse> Handle(GetAllAccountBalancesByCategoryQuery request, CancellationToken cancellationToken)
        {
            ApiResponse response = new ApiResponse();

            try
            {
                var inputLevelList = await _dbContext.ChartOfAccountNew
                    .Where(x => x.IsDeleted == false && x.AccountHeadTypeId == request.id && x.AccountLevelId == (int)AccountLevels.InputLevel)
                    .Include(x => x.AccountType)
                    .ToListAsync();

                if (inputLevelList.Any(x => x.AccountTypeId == null))
                    throw new Exception("Some accounts do not have notes assigned to them!");

                AccountBalanceFunctions accountBalanceFunctions= new AccountBalanceFunctions(_dbContext);

                var accountBalances = await accountBalanceFunctions.GetAccountBalances(inputLevelList, request.asOfDate, request.currency);

                var notes = inputLevelList.Select(x => x.AccountType).Distinct().ToList();
                List<NoteAccountBalancesModel> noteAccountBalances = new List<NoteAccountBalancesModel>();

                foreach (var note in notes)
                {
                    var currNoteBalances = accountBalances.Where(x => x.Key.AccountTypeId == note.AccountTypeId).ToDictionary(x => x.Key, x => x.Value);

                    var vmNoteBalances = accountBalanceFunctions.GenerateBalanceViewModels(currNoteBalances);

                    var currNoteAccountBalances = new NoteAccountBalancesModel();

                    currNoteAccountBalances.NoteId = note.AccountTypeId;
                    currNoteAccountBalances.NoteName = note.AccountTypeName;
                    currNoteAccountBalances.NoteHeadId = note.AccountHeadTypeId;
                    currNoteAccountBalances.AccountBalances = vmNoteBalances;
                    noteAccountBalances.Add(currNoteAccountBalances);
                }

                response.data.NoteAccountBalances = noteAccountBalances;
                response.StatusCode = StaticResource.successStatusCode;
                response.Message = "Success";
            }
            catch (Exception ex)
            {
                response.StatusCode = StaticResource.failStatusCode;
                response.Message = ex.Message;
            }

            return response;
        }
    }
}