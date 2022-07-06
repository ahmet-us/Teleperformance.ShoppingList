using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teleperformance.ShoppingList.Domain.Models
{
    public enum QuantityTypes
    {
        Liter,
        Kilo,
        Piece
    }
    public class ListItem
    {
        public int Id { get; set; }
        [Required]
        public string? ItemName { get; set; }
        public bool IsCompleted { get; set; } = false;
        public int ShoppingListId { get; set; }
        [Required]
        public float ItemQuantity { get; set; }
        [Required]
        public QuantityTypes Type { get; set; }

        public ShoppingList? ShoppingList { get; set; }

    }
}
