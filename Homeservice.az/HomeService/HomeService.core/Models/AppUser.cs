using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.core.Models
{
    public class AppUser:IdentityUser
    {
        public bool IsDeleted { get; set; }

    }
}
