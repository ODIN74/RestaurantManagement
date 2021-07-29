using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Required]
        public Tables Table { get; set; }

        [Required]
        public IdentityUser Waiter { get; set; }

        [Required]
        public DateTime OrderTime { get; set; }

        [Required]
        public List<Dishes> Dishes { get; set; }

        [Required]
        public float TotalCost { get; set; }

        public bool IsPaidFor { get; set; } = false;

        public PaymentMethod? PaymentMethod { get; set; }
    }
}
