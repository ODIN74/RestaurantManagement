using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManagement.Data
{
    public class DishesInPreparation
    { 
        public int Id { get; set; }

        [Required]
        public Dishes Dish { get; set; }

        public IdentityUser Cook { get; set; }

        [Required]
        public DateTime OrderTime { get; set; }

        public DateTime ReadyTime { get; set; }

        public bool IsReady { get; set; } = false;
    }
}
