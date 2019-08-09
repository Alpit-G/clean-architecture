using AutoMapper;
using HumanitarianAssistance.Application.Accounting.Models;
using HumanitarianAssistance.Application.Project.Commands.Update;
using HumanitarianAssistance.Domain.Entities.Accounting;
using HumanitarianAssistance.Domain.Entities.Project;

namespace HumanitarianAssistance.WebApi.Infrastructure
{
    public class AutoMapperProfile : Profile
    {

        public AutoMapperProfile() : this("MyProfile")
        {
        }
        protected AutoMapperProfile(string profileName) : base(profileName)
        {
            CreateMap<VoucherDetail, VoucherDetailEntityModel>().ReverseMap();
            CreateMap<VoucherDetail, VoucherDetailModel>().ReverseMap();
            CreateMap<ProgramDetail, EditProgramDetailCommand>().ReverseMap();



        }
    }
}