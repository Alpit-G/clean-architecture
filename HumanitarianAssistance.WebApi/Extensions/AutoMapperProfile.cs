using AutoMapper;
using HumanitarianAssistance.Application.Accounting.Models;
using HumanitarianAssistance.Domain.Entities;

namespace HumanitarianAssistance.WebApi.Extensions
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



        }
    }
}