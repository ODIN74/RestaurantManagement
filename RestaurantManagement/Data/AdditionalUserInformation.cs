using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace RestaurantManagement.Data
{
    public class AdditionalUserInformation
    {
        public int id { get; set; }

        [Key]
        public string UserId { get; set; }

        [StringLength(30)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(6)]
        public string PostalCode { get; set; }

        [StringLength(30)]
        public string City { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        [StringLength(1000)]
        public string AboutMe { get; set; }

        public string PhotoUrl { get; set; }
    }
}
