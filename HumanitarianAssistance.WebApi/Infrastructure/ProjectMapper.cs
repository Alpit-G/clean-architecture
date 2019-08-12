using AutoMapper;
using HumanitarianAssistance.Application.Project.Commands.Common;
using HumanitarianAssistance.Domain.Entities.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumanitarianAssistance.WebApi.Infrastructure
{
    public class ProjectMapper : Profile
    {
        public ProjectMapper()
        {
            CreateMap<AddEditProjectDetailCommand, ProjectDetail>().ReverseMap();
        }
    }
}
