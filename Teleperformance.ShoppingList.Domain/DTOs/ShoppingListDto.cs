using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teleperformance.ShoppingList.Domain.Models;

namespace Teleperformance.ShoppingList.Domain.DTOs
{
    public class ShoppingListDto
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public ListCategories Category { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime CompleteTime { get; set; }
        public int UserId { get; set; }
    }

    public class ShoppingListCreationDto : ShoppingListAddUpdateDto
    {

    }
    public class ShoppingListUpdateDto : ShoppingListAddUpdateDto
    {

    }
    public abstract class ShoppingListAddUpdateDto
    {

        [Required]
        public string? Name { get; set; }

        [Required]
        public ListCategories Category { get; set; }

        public IEnumerable<ListItemCreationDto>? ListItems { get; set; }
    }
}
