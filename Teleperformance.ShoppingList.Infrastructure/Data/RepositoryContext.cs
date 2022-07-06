using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teleperformance.ShoppingList.Domain.Models;

namespace Teleperformance.ShoppingList.Infrastructure.Data
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ShoppingListData());
            modelBuilder.ApplyConfiguration(new UserData());
            modelBuilder.ApplyConfiguration(new ListItemData());
        }

        public DbSet<ListItem> ListItems { get; set; }
        public DbSet<Domain.Models.ShoppingList> ShoppingLists { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
