using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teleperformance.ShoppingList.Domain.DTOs
{
    public class UserDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        private bool IsAdmin { get; set; } = false;
    }
    public class UserCreationDto : UserAddUpdateDto
    {

    }
    public class UserUpdateDto : UserAddUpdateDto
    {

    }
    public abstract class UserAddUpdateDto
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
        private bool IsAdmin { get; set; } = false;

        public IEnumerable<ShoppingListCreationDto>? ShoppingLists { get; set; }

    }
}
