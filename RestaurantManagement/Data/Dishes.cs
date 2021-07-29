using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace RestaurantManagement.Data
{
    public class Dishes
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        
        [Required]
        public bool IsRequiresPreparation{ get; set; }

        public int CookingTimeInMinutes { get; set; }

        public bool IsAgreed { get; set; } = false;
    }
}
