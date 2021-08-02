using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using RestaurantManagement.Data;

namespace RestaurantManagement.Models.Dishes
{
    public class DishCreateModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string DishCategoryName { get; set; }

        [Required]
        public int DishCategoryId { get; set; }

        [Required] public int[] DishIngredientsIds { get; set; } = new int[0];

        [Required] public string[] DishIngredientsWeights { get; set; } = new string[0];

        [Required]
        public string DishCookingTimeInMinutes { get; set; }

        [Required] public bool IsRequiresPreparation { get; set; } = true;

        public List<Ingredients> Ingredients { get; set; } = new List<Ingredients>();

        public List<MenuCategory> Categories { get; set; } = new List<MenuCategory>();
    }
}
