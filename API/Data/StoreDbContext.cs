
using Microsoft.EntityFrameworkCore;
namespace API.Data
{
    public class StoreDbContext(DbContextOptions<StoreDbContext> options) : DbContext(options)
    {
    }
}
