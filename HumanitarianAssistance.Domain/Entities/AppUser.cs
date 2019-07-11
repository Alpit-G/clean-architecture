using System;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace HumanitarianAssistance.Domain.Entities
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsDeleted { get; set; }
    }
}
