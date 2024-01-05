using booking_api.Model;
using Microsoft.EntityFrameworkCore;

namespace booking_api.Context
{
    public class DataContext : DbContext
    {
       
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Passagens> Passagens { get; set; }

        public DbSet<Compras> Compras { get; set; }


    }
}
