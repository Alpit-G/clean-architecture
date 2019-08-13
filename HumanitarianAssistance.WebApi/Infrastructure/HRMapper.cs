using AutoMapper;
using HumanitarianAssistance.Application.HR.Models;
using HumanitarianAssistance.Domain.Entities.HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumanitarianAssistance.WebApi.Infrastructure
{
    public class HRMapper : Profile
    {
        public HRMapper()
        {
            CreateMap<EmployeeHealthInfo,EmployeeHealthInformationModel>().ReverseMap();
        }
    }
}
