﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManagement.Data
{
    public class Price
    {
        public int Id { get; set; }

        public Dishes Dish { get; set; }

        public float Cost { get; set; }
    }
}
