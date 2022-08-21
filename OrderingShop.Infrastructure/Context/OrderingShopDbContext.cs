using Microsoft.EntityFrameworkCore;
using OrderingShop.Infrastructure.Context.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OrderingShop.Infrastructure.Context
{
    public class OrderingShopDbContext : DbContext
    {
        public OrderingShopDbContext(DbContextOptions<OrderingShopDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
