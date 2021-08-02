using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManagement.Data
{
    public class DishesViewModel
    {
        public List<Dishes> DishesList { get; set; }

        public List<MenuCategory> CategoriesList { get; set; }

        public IEnumerable<DishesInCategories> DishesInCategories { get; set; }
    }
}
