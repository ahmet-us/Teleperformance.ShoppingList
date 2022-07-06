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
    public class UserData : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User
                {
                    Id = 1,
                    Name = "Ali",
                    Email = "ali@tp.com.tr",
                    Password = "12345",
                    IsAdmin = true,
                },
                new User
                {
                    Id = 2,
                    Name = "Veli",
                    Email = "veli@tp.com.tr",
                    Password = "012345",
                    
                },
                new User
                {
                    Id = 3,
                    Name = "Murat",
                    Email = "murat@tp.com.tr",
                    Password = "54321",
                }
                ) ;
        }
    }
}
