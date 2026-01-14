using Microsoft.EntityFrameworkCore;
using Inventario_Equipos.Models;

namespace Inventario_Equipos.Data
{
    public class InventaryDbContext : DbContext
    {
        public InventaryDbContext(DbContextOptions<InventaryDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Computer> Computers { get; set; }
        public DbSet<Asignation> Asignations { get; set; }
        public DbSet<Maintenance> Maintenances { get; set; }
    }
}
