using Microsoft.EntityFrameworkCore;
using Hackaton.Shared.Entities;

namespace Hackaton.API.DATA
{
    public class DataContext : DbContext
    {
        // Constructor
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        // Definir los DbSets (tablas) para cada entidad
        public DbSet<HackatonEntity> Hackatons { get; set; }  // Entidad HackatonEntity
        public DbSet<Equipo> Equipos { get; set; }      // Entidad Equipo
        public DbSet<Participante> Participantes { get; set; }  // Entidad Participante
        public DbSet<Mentor> Mentores { get; set; }     // Entidad Mentor
        public DbSet<Proyecto> Proyectos { get; set; }  // Entidad Proyecto
        public DbSet<Evaluacion> Evaluaciones { get; set; } // Entidad Evaluación
        public DbSet<Premio> Premios { get; set; }      // Entidad Premio

        // Método para definir restricciones adicionales
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración adicional (índices únicos, restricciones, etc.)
            modelBuilder.Entity<HackatonEntity>().HasIndex(h => h.Nombre).IsUnique();
            modelBuilder.Entity<Equipo>().HasIndex(e => e.Nombre).IsUnique();
        }
    }
}
