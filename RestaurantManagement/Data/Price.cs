using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManagement.Data
{
    public class Price
    {
        public int Id { get; set; }

        [Required]
        public Dishes Dish { get; set; }

        [Required]
        public float Cost { get; set; }
    }
}
