using Microsoft.EntityFrameworkCore;

namespace POSBackendApi.DbServices.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }

        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {

        }
        public virtual DbSet<TblProductCategory> TblProductCategories { get; set; }

    }
}
