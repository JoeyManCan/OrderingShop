using Microsoft.EntityFrameworkCore;
using OrderingShop.Infrastructure.Context;

namespace OrderingShop.Configuration
{
    public static class DependencyInjection
    {
        public static void AddInfrastructureApi(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<OrderingShopDbContext>(options => options.UseSqlServer(connectionString));
        }
    }

}
