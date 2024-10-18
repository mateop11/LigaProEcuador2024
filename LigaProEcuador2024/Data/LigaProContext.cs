using Microsoft.EntityFrameworkCore;
using LigaProEcuador2024.Models;

namespace LigaProEcuador2024.Data
{
    public class LigaProContext : DbContext
    {
        public LigaProContext(DbContextOptions<LigaProContext> options) : base(options)
        {
        }

        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Jugador> Jugadores { get; set; }
        public DbSet<Estadio> Estadios { get; set; }
    }
}
