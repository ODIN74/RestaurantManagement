using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManagement.Data
{
    public class MenuCategory : IComparable<MenuCategory>
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int CompareTo(MenuCategory other)
        {
            if(other == null) return 1;
            return this.Name.CompareTo(other.Name);
        }
    }
}
