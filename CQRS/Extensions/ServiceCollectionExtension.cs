using CQRS.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PMSCore.Data.EntityFrameWork.Repositories;
using System.Reflection;

namespace CQRS.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddCustomAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }

        public static IServiceCollection AddCommonService(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddScoped(typeof(IUserRepository), typeof(UserRepository));

            return services;
        }
        public static IServiceCollection AddCustomDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("PMSCore"); //Enter your connection string
            services.AddDbContext<Models.DbContext>(options => options.UseSqlServer(connectionString));
            return services;
        }
    }
}
