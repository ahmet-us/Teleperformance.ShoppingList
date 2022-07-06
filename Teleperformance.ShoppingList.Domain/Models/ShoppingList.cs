using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teleperformance.ShoppingList.Domain.Models
{
    public enum ListCategories
    {
        School,
        Supermarket,
        Repair
    }
    public class ShoppingList
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public ListCategories Category { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime CompleteTime { get; set; }
        public int UserId { get; set; }
        
        public ICollection<ListItem>? ListItems { get; set; }

        public User? Users { get; set; }

    }
}
