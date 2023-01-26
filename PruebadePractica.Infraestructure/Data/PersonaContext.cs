using Microsoft.EntityFrameworkCore;
using PruebadePractica.Core.Entities;
using PruebadePractica.Infraestructure.Data.Configurations;

namespace PruebadePractica.Infraestructure.Data
{
    public partial class PersonaContext : DbContext
    {
        public PersonaContext()
        {
                
        }

        public PersonaContext(DbContextOptions<PersonaContext> options) 
            : base(options) 
        { 
        }

        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<InformacionPersona> InformacionPersonas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonaConfiguration());
            modelBuilder.ApplyConfiguration(new InformacionPersonaConfiguration());

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
