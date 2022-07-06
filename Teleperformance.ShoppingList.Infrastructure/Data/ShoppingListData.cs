using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teleperformance.ShoppingList.Infrastructure.Data
{
    public class ShoppingListData : IEntityTypeConfiguration<Domain.Models.ShoppingList>
    {
        public void Configure(EntityTypeBuilder<Domain.Models.ShoppingList> builder)
        {
            builder.HasData(
                new Domain.Models.ShoppingList
                {
                    Id = 1,
                    Name = "Bakkal",
                    Category = Domain.Models.ListCategories.Supermarket,
                    CreateTime = DateTime.Now,
                    UserId = 1,


                },
                new Domain.Models.ShoppingList
                {
                    Id = 2,
                    Name = "Universite",
                    Category = Domain.Models.ListCategories.School,
                    CreateTime = DateTime.Now,
                    UserId = 1,


                },
                new Domain.Models.ShoppingList
                {
                    Id = 3,
                    Name = "Boya Badana",
                    Category = Domain.Models.ListCategories.Repair,
                    CreateTime = DateTime.Now,
                    UserId = 1,


                }
                );
        }
    }
}
