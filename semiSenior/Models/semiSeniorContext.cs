using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace semiSenior.Models
{
    public partial class semiSeniorContext : DbContext
    {
        public semiSeniorContext()
        {
        }

        public semiSeniorContext(DbContextOptions<semiSeniorContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Paciente> Paciente { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=ITH_PF2VWEBQ;Initial Catalog=semiSenior;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Paciente>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Apellido)
                    .HasColumnName("apellido")
                    .HasMaxLength(50);

                entity.Property(e => e.CantidadHijos)
                    .HasColumnName("cantidadHijos")
                    .HasMaxLength(3);

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasMaxLength(50);

                entity.Property(e => e.Documento)
                    .HasColumnName("documento")
                    .HasMaxLength(10);

                entity.Property(e => e.Edad)
                    .HasColumnName("edad")
                    .HasMaxLength(3);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.EstadoCivil)
                    .HasColumnName("estadoCivil")
                    .HasMaxLength(10);

                entity.Property(e => e.Genero)
                    .HasColumnName("genero")
                    .HasMaxLength(10);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
