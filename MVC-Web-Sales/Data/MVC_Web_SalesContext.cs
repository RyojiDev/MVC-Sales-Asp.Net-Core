
using Microsoft.EntityFrameworkCore;
using MVC_Web_Sales.Models;

namespace MVC_Web_Sales.Data
{
    public class MVC_Web_SalesContext : DbContext
    {
        public MVC_Web_SalesContext (DbContextOptions<MVC_Web_SalesContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
