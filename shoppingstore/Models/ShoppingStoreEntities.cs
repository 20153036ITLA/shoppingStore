using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace shoppingstore.Models
{
    public class ShoppingStoreEntities : DbContext
    {
        public ShoppingStoreEntities() : base("ShoppingStoreEntities")
        {


        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }

        public System.Data.Entity.DbSet<shoppingstore.Models.Producer> Producers { get; set; }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>()
             .Property(c => c.ItemId)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }

        public System.Data.Entity.DbSet<shoppingstore.ViewModels.ShoppingCartViewModel> ShoppingCartViewModels { get; set; }
    }
}