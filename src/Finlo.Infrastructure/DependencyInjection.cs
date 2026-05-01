using Finlo.Infrastructure.Persistence.Sql;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Finlo.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        // Register your infrastructure services here, e.g., DbContext, repositories, etc.
        // Example:
        // services.AddDbContext<FinloDbContext>(options =>
        //     options.UseSqlite(configuration.GetConnectionString("DefaultConnection")));

        services.AddDbContext<FinloDbContext>(options =>
            options.UseSqlite(configuration.GetConnectionString("DefaultConnection")));

        return services;
    }
}
