
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManagement.Data
{
    public class DishCreateModel
    {
        public string[] IngredientsIds { get; set; }

        public string[] IngredientsWeights { get; set; }



        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public bool IsRequiresPreparation { get; set; }

        public int CookingTimeInMinutes { get; set; }

        public bool IsAgreed { get; set; } = false;
    }
}
