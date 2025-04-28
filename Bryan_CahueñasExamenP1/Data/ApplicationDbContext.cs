using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Bryan_CahueñasExamenP1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<PlanRecompensa> PlanesRecompensa { get; set; }
    }
}