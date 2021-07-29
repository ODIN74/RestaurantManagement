using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace RestaurantManagement.Data
{
    public enum PaymentMethod
    {
        Cash,
        NonCash
    }

    public class Order
    {
        public int Id { get; set; }

        public string TableId { get; set; }

        public string WaiterId { get; set; }

        public DateTime OrderTime { get; set; }

        public string DishIdList { get; set; }

        public float TotalCost { get; set; }

        public bool IsPaidFor { get; set; }

        public PaymentMethod? PaymentMethod { get; set; }
    }
}
