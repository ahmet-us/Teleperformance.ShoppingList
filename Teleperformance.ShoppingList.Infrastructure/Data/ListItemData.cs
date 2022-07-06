using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teleperformance.ShoppingList.Domain.Models;

namespace Teleperformance.ShoppingList.Infrastructure.Data
{
    public class ListItemData : IEntityTypeConfiguration<ListItem>
    {
        public void Configure(EntityTypeBuilder<ListItem> builder)
        {
            builder.HasData(
                new ListItem
                {
                    Id = 1,
                    ShoppingListId = 1,
                    IsCompleted = false,
                    ItemName = "Milk",
                    ItemQuantity = 1,
                    Type = QuantityTypes.Liter,
                },
                new ListItem
                {
                    Id = 2,
                    ShoppingListId = 1,
                    IsCompleted = false,
                    ItemName = "Banana",
                    ItemQuantity = 2,
                    Type = QuantityTypes.Kilo,
                },
                new ListItem
                {
                    Id = 3,
                    ShoppingListId = 1,
                    IsCompleted = false,
                    ItemName = "Bread",
                    ItemQuantity = 1,
                    Type = QuantityTypes.Piece,
                },
                new ListItem
                {
                    Id = 4,
                    ShoppingListId = 2,
                    IsCompleted = false,
                    ItemName = "Notebook",
                    ItemQuantity = 2,
                    Type = QuantityTypes.Piece,
                },
                new ListItem
                {
                    Id = 5,
                    ShoppingListId = 2,
                    IsCompleted = false,
                    ItemName = "Bag",
                    ItemQuantity = 1,
                    Type = QuantityTypes.Piece,
                },
                new ListItem
                {
                    Id = 6,
                    ShoppingListId = 3,
                    IsCompleted = false,
                    ItemName = "Paint",
                    ItemQuantity = 5,
                    Type = QuantityTypes.Liter,
                },
                new ListItem
                {
                    Id = 7,
                    ShoppingListId = 3,
                    IsCompleted = false,
                    ItemName = "Paintbrush",
                    ItemQuantity = 2,
                    Type = QuantityTypes.Piece,
                }
                );
        }
    }
}
