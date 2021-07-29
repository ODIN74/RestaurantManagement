using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManagement.Data
{
    public class IngredientsWeights
    {
        public int Id { get; set; }
        [Required]
        public Ingredients Ingredient { get; set; }

        [Required]
        public Dishes Dish { get; set; }

        [Required]
        public float Weight { get; set; }
    }
}
