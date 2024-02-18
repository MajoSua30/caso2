using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace caso2.Models;

public partial class PracticaProgramadaContext : DbContext
{
    public PracticaProgramadaContext()
    {
    }

    public PracticaProgramadaContext(DbContextOptions<PracticaProgramadaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Lista> Listas { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

       => optionsBuilder.UseSqlServer("Server=MARIA\\SQLEXPRESS; Database=PracticaProgramada; Trusted_Connection=True; TrustServerCertificate=True; integrated security=true ");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Lista>(entity =>
        {
            entity.HasKey(e => e.Nombrelista).HasName("PK__LISTAS__80DE8B01D7D14452");

            entity.ToTable("LISTAS");

            entity.Property(e => e.Nombrelista)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("NOMBRELISTA");
            entity.Property(e => e.Estado)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.Fechahacer).HasColumnName("FECHAHACER");
            entity.Property(e => e.Nombreactvidad)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("NOMBREACTVIDAD");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuarios__3214EC07D4C8A4DE");

            entity.Property(e => e.Correo)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Usario)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
