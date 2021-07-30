using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace RestaurantManagement.Models.Roles
{
    public class RoleEditModel
    {
        public string RoleId { get; set; }

        [Required]
        public string RoleName { get; set; }

        public Dictionary<IdentityUser, bool> UsersInRoleStatus;
    }
}
