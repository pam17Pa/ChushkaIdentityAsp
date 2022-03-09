using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChushkaIdentityASP.Data
{
    public class User: IdentityUser
    {
        [Key]
        public string FullName { get; set; }
        public RoleType Roles { get; set; }
        public DateTime DateOfBirth { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
