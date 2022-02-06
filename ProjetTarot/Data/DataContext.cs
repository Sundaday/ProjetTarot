using Microsoft.EntityFrameworkCore;
using ProjetTarot.Models;

namespace ProjetTarot.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Player> Players { get; set; }
    }
}
