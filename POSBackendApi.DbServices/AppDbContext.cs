using Microsoft.EntityFrameworkCore;

namespace POSBackendApi.DbServices
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }

        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option) {

        }


    }
}
