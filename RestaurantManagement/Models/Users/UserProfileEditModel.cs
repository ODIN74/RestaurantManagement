using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace RestaurantManagement.Models.Users
{
    public class UserProfileEditModel
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [StringLength(30)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        [StringLength(30)]
        public string City { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [StringLength(6)]
        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }

        [StringLength(1000)]
        public string AboutMe { get; set; }
    }

}
