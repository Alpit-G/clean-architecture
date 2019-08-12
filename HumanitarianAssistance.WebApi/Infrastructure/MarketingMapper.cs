using AutoMapper;
using HumanitarianAssistance.Application.Marketing.Commands.Common;
using HumanitarianAssistance.Application.Marketing.Commands.Create;
using HumanitarianAssistance.Application.Marketing.Commands.Update;
using HumanitarianAssistance.Domain.Entities;
using HumanitarianAssistance.Domain.Entities.Marketing;

namespace HumanitarianAssistance.WebApi.Infrastructure
{
    public class MarketingMapper : Profile
    {
        public MarketingMapper()
        {
            CreateMap<ClientDetails, AddClientDetailsCommand>().ReverseMap();
            CreateMap<Quality, AddEditQualityCommand>().ReverseMap();
            CreateMap<TimeCategory, AddEditTimeCategoryCommand>().ReverseMap();
            CreateMap<Category, AddCategoryCommand>().ReverseMap();
            CreateMap<LanguageDetail, AddLanguageCommand>().ReverseMap();
            CreateMap<Category, EditCategoryCommand>().ReverseMap();
            CreateMap<ClientDetails, EditClientDetailsCommand>().ReverseMap(); 
        }
    }
}
