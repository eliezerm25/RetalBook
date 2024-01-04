using DataModel.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public static class DataModelLayerSetup
    {
        public static IServiceCollection DataModelLayerSetupAdd(this IServiceCollection services, IConfiguration configuration) {


            services.AddDbContext<DataContext>(options =>
                                         options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<DataContext>();
            return services;
        }

    }
}
