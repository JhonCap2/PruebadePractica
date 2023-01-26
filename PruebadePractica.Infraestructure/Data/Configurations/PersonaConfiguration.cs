using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PruebadePractica.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebadePractica.Infraestructure.Data.Configurations
{
    public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.ToTable("Persona");
            builder.HasKey(e => e.IdPerson);

            builder.Property(e =>e.IdPerson)
                .HasColumnName("IdPerson");

            builder.Property(e => e.Names)
                .HasColumnName("NamesPerson")
                .ValueGeneratedNever()
                .IsUnicode(false);

            builder.Property(e =>e.LastName)
                .HasColumnName("LastNamesPerson")
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.DateOfBirth)
                .HasColumnName("DateofBirth")
                .HasColumnType("datetime");

            builder.Property(e => e.Identification)
                .HasColumnName("Identity")
                .HasMaxLength(11);
        }
    }
}
