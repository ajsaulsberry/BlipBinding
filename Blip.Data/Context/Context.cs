using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Blip.Entities.Customers;
using Blip.Entities.Geographies;
using Blip.Entities.Items;
using Blip.Entities.Orders;

namespace Blip.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("ApplicationDbContext")
        {

        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}