using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using UserApp.Infrastructure.Configurations;
using UserApp.Infrastructure.DbContext;

namespace UserApp.Infrastructure.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        //for windows os
        //services.AddDbContext<AppDbContext>(options => options.UseSqlServer(DatabaseConfigurations.CONNECTIONSTRING));
        
        //for macos
        services.AddDbContext<AppDbContext>(options => options.UseSqlServer(DatabaseConfigurations.MAC_CONNECTIONSTRING));

        return services;
    }
}