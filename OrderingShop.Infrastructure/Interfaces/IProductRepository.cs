using OrderingShop.Infrastructure.Context.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingShop.Infrastructure.Interfaces
{
    public interface IProductRepository:IRepository<Product>
    {
    }
}
