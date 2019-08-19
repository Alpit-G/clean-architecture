using AutoMapper;
using HumanitarianAssistance.Application.Configuration.Commands.Create;
using HumanitarianAssistance.Domain.Entities;

namespace HumanitarianAssistance.WebApi.Infrastructure
{
    public class ConfigurationMapper: Profile
    {
        public ConfigurationMapper()
        {
            CreateMap<AddContractContentCommand,ContractTypeContent>().ReverseMap();
        }
    }
}