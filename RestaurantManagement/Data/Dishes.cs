using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace RestaurantManagement.Data
{
    public class Dishes
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string IngredientsId { get; set; }

        public string IngredientsWeight { get; set; }

        public bool IsRequiritPraeparationem { get; set; }

        public int CookingTimeInMinutes { get; set; }
    }
}
