using AdopcionWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Reflection.Metadata;

namespace AdopcionWeb.Data;

public class AdopcionContext : DbContext
{
    public AdopcionContext(DbContextOptions<AdopcionContext> options)
        : base(options)
    {
    }
    public virtual DbSet<Adopcion> Adopciones { get; set; }
    public virtual DbSet<Mascota> Mascotas { get; set; }
    public virtual DbSet<Persona> Personas { get; set; }
    public virtual DbSet<Visita> Visitas { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //=> optionsBuilder.UseMySql("DataSource=localhost;Database=bdappcofinal;User Id=root;Password=Cofinal2022+14;Port=3306;SslMode=0", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.31-mysql"));
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Visita>()

            .HasOne(v => v.Adopcion)
            .WithMany(a => a.Visitas)
            .HasForeignKey(v => v.AdopcionId);

        modelBuilder.Entity<Adopcion>()
            .HasOne(a => a.Mascota)
            .WithMany(m => m.Adopciones)
            .HasForeignKey(a => a.MascotaId);

        modelBuilder.Entity<Adopcion>()
            .HasOne(a => a.Persona)
            .WithMany(p => p.Adopciones)
            .HasForeignKey(a => a.PersonaId);
    }
}
