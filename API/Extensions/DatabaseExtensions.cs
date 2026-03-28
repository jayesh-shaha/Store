using Microsoft.EntityFrameworkCore;

using API.Data;
namespace API.Extensions
{
    public static class DatabaseExtensions
    {
        public static void AddDatabaseConfiguration(this WebApplicationBuilder builder)
        {
            var conn = builder.Configuration.GetConnectionString("DefaultConnection");
            if (string.IsNullOrEmpty(conn))
            {
                throw new Exception("Database connection string is missing");
            }

            builder.Services.AddDbContext<StoreDbContext>(options =>
                   options.UseSqlite(conn
                   ));
        }
    }
}
