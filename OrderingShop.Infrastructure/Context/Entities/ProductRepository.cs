using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderingShop.Infrastructure.Interfaces;
using OrderingShop.Infrastructure.Context.Entities;
using Microsoft.EntityFrameworkCore;

namespace OrderingShop.Infrastructure.Context.Entities
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(OrderingShopDbContext context) : base(context)
        {
        }
    }
}
