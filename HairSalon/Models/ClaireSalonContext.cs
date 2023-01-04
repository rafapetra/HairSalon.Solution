using Microsoft.EntityFrameworkCore;

namespace ClaireSalon.Models
{
  public class ClaireSalonContext : DbContext
  {
    public DbSet<Client> Clients { get; set; }
    public DbSet<Stylist> Stylists { get; set; }

    public ClaireSalonContext(DbContextOptions options) : base(options) { }
  }
}





















































