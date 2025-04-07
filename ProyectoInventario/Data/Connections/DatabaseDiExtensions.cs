using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace ProyectoInventario.Data.Connections;

public static class DatabaseDiExtensions
{
    public static void AddPostgreSql(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IDbConnectionManager, DBConnectionManager>();

        services.AddDbContext<Context>(options => 
        options.UseNpgsql(configuration.GetConnectionString("PostgreSQLConnection")));
    }
}
