using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjectDataAccsesLayer.Abstract.Products;
using ProjectDataAccsesLayer.Concrete.EntityFrameworkRepositories.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBusinessLogic.Ioc
{
    public static class ServicesExtension
    {
        public static void AddServices( this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
