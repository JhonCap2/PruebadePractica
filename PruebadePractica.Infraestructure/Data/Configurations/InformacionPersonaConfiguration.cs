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
    public class InformacionPersonaConfiguration : IEntityTypeConfiguration<InformacionPersona>
    {
        public void Configure(EntityTypeBuilder<InformacionPersona> builder)
        {
            builder.ToTable("InformacionPersona");
            builder.HasKey(e => e.IdInformacionPersona);

            builder.Property(e => e.IdInformacionPersona)
                .HasColumnName("IdInformacionPersona");

            builder.Property(e => e.IdPerson)
                .HasColumnName("IdPersonId");

            builder.Property(e => e.PhoneNumber)
                .HasColumnName("PhoneNumber")
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.Email)
                .HasColumnName("Email");

            builder.Property(e => e.Work)
                .HasColumnName("Work");

            builder.HasOne(d => d.Persona)
                .WithMany(p => p.InformacionPersonas)
                .HasForeignKey(d => d.IdPerson)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Fk_Persona_Id_Person");
        }
    }
}
