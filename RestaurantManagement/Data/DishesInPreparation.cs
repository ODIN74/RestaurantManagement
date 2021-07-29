using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManagement.Data
{
    public class DishesInPreparation
    { 
        public int Id { get; set; }

        [Key]
        public int DishId { get; set; }

        [Key]
        public string CookId { get; set; }

        public DateTime OrderTime { get; set; }

        public DateTime ReadyTime { get; set; }

        public bool IsReady { get; set; } = false;
    }
}
