﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PruebadePractica.Infraestructure.Data;

#nullable disable

namespace PruebadePractica.Infraestructure.Migrations
{
    [DbContext(typeof(PersonaContext))]
    [Migration("20230126193557_persona10")]
    partial class persona10
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PruebadePractica.Core.Entities.InformacionPersona", b =>
                {
                    b.Property<int>("IdInformacionPersona")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdInformacionPersona");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdInformacionPersona"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Email");

                    b.Property<int>("PersonaId")
                        .HasColumnType("int")
                        .HasColumnName("PersonaId");

                    b.Property<int>("PhoneNumber")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("int")
                        .HasColumnName("PhoneNumber");

                    b.Property<string>("Work")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Work");

                    b.HasKey("IdInformacionPersona");

                    b.HasIndex("PersonaId");

                    b.ToTable("InformacionPersona", (string)null);
                });

            modelBuilder.Entity("PruebadePractica.Core.Entities.Persona", b =>
                {
                    b.Property<int>("IdPerson")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdPerson");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPerson"));

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime")
                        .HasColumnName("DateofBirth");

                    b.Property<int>("Identification")
                        .HasColumnType("int")
                        .HasColumnName("Identity");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("LastNamesPerson");

                    b.Property<string>("Names")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("NamesPerson");

                    b.HasKey("IdPerson");

                    b.ToTable("Persona", (string)null);
                });

            modelBuilder.Entity("PruebadePractica.Core.Entities.InformacionPersona", b =>
                {
                    b.HasOne("PruebadePractica.Core.Entities.Persona", "Personas")
                        .WithMany("InformacionPersonas")
                        .HasForeignKey("PersonaId")
                        .IsRequired()
                        .HasConstraintName("Fk_Persona_Id");

                    b.Navigation("Personas");
                });

            modelBuilder.Entity("PruebadePractica.Core.Entities.Persona", b =>
                {
                    b.Navigation("InformacionPersonas");
                });
#pragma warning restore 612, 618
        }
    }
}
