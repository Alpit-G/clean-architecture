using HumanitarianAssistance.Common.Helpers;
using HumanitarianAssistance.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HumanitarianAssistance.Application.CommonFunctions
{
    internal class ProjectFunctions
    {
        private readonly HumanitarianAssistanceDbContext _dbContext;
        public ProjectFunctions(HumanitarianAssistanceDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
    }
}
