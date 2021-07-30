using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManagement.Models.Users
{
    public class UserEditModel : UserCreateModel
    {
        public string Id { get; set; }

        public new string Password { get; set; }
    }
}
