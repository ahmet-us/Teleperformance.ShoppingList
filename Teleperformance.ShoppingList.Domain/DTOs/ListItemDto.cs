using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teleperformance.ShoppingList.Domain.Models;

namespace Teleperformance.ShoppingList.Domain.DTOs
{
    public class ListItemDto
    {
        public int Id { get; set; }
        
        public string? ItemName { get; set; }
        public bool IsCompleted { get; set; } = false;
        public int ShoppingListId { get; set; }
        public float ItemQuantity { get; set; }
        public QuantityTypes Type { get; set; }

    }

    public class ListItemCreationDto : ListItemAddUpdateDto
    {

    }

    public class ListItemUpdateDto : ListItemAddUpdateDto
    {

    }

    public abstract class ListItemAddUpdateDto
    {
        [Required]
        public string? ItemName { get; set; }
        public bool IsCompleted { get; set; } = false;
        [Required]
        public float ItemQuantity { get; set; }
        [Required]
        public QuantityTypes Type { get; set; }
    }
}
