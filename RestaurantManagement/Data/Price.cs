using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManagement.Data
{
    public class Price
    {
        public int Id { get; set; }

        public int DishId { get; set; }

        public float Cost { get; set; }
    }
}
