﻿// <auto-generated />
using System;
using AdopcionWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AdopcionWeb.Migrations
{
    [DbContext(typeof(AdopcionContext))]
    [Migration("20240916144740_CreacionTablas")]
    partial class CreacionTablas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AdopcionWeb.Models.Adopcion", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("FechaAdopcion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaTerminoSeguimiento")
                        .HasColumnType("datetime2");

                    b.Property<long>("MascotaId")
                        .HasColumnType("bigint");

                    b.Property<long>("PersonaId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("MascotaId");

                    b.HasIndex("PersonaId");

                    b.ToTable("Adopciones");
                });

            modelBuilder.Entity("AdopcionWeb.Models.Mascota", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Caracteristicas")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("EsValido")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaEncontrado")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaPosibleNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PosiblesEnfermedades")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Raza")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("TipoMascota")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Mascotas");
                });

            modelBuilder.Entity("AdopcionWeb.Models.Persona", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("DescripcionHogar")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("EsValido")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("AdopcionWeb.Models.Visita", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("AdopcionId")
                        .HasColumnType("bigint");

                    b.Property<bool>("CondicionesMascota")
                        .HasColumnType("bit");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaVisita")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AdopcionId");

                    b.ToTable("Visitas");
                });

            modelBuilder.Entity("AdopcionWeb.Models.Adopcion", b =>
                {
                    b.HasOne("AdopcionWeb.Models.Mascota", "Mascota")
                        .WithMany("Adopciones")
                        .HasForeignKey("MascotaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AdopcionWeb.Models.Persona", "Persona")
                        .WithMany("Adopciones")
                        .HasForeignKey("PersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mascota");

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("AdopcionWeb.Models.Visita", b =>
                {
                    b.HasOne("AdopcionWeb.Models.Adopcion", "Adopcion")
                        .WithMany("Visitas")
                        .HasForeignKey("AdopcionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Adopcion");
                });

            modelBuilder.Entity("AdopcionWeb.Models.Adopcion", b =>
                {
                    b.Navigation("Visitas");
                });

            modelBuilder.Entity("AdopcionWeb.Models.Mascota", b =>
                {
                    b.Navigation("Adopciones");
                });

            modelBuilder.Entity("AdopcionWeb.Models.Persona", b =>
                {
                    b.Navigation("Adopciones");
                });
#pragma warning restore 612, 618
        }
    }
}
