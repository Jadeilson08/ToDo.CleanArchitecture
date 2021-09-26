using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Infra.Data.Context;

namespace ToDo.Infra.IoC
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            /*services.AddEntityFrameworkNpgsql()
            .AddDbContext<PostgresContext>(options => options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));*/

            services.AddDbContext<ApiDbContext>(opt => opt.UseInMemoryDatabase());

            return services;
        }
    }
}
