using System;
using System.Collections.Generic;
using Gestion_Cursos.Models;
using Microsoft.EntityFrameworkCore;

namespace Gestion_Cursos.Data;

public partial class Gestion_Curso_DbContext : DbContext
{
    public Gestion_Curso_DbContext()
    {
    }

    public Gestion_Curso_DbContext(DbContextOptions<Gestion_Curso_DbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Credenciale> Credenciales { get; set; }

    public virtual DbSet<Curso> Cursos { get; set; }

    public virtual DbSet<Estudiante> Estudiantes { get; set; }

    public virtual DbSet<Inscripcione> Inscripciones { get; set; }

    public virtual DbSet<Profesore> Profesores { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=.;Database=Gestion_Cursos_DB;User Id=sa;Password=12345;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Credenciale>(entity =>
        {
            entity.HasKey(e => e.CredencialId).HasName("PK__Credenci__9025E6E799CA68F3");

            entity.HasIndex(e => e.UsuarioId, "UQ__Credenci__2B3DE79974BF0220").IsUnique();

            entity.HasIndex(e => e.Correo, "UQ__Credenci__60695A196A913216").IsUnique();

            entity.Property(e => e.CredencialId).HasColumnName("CredencialID");
            entity.Property(e => e.Contrasenia).HasMaxLength(256);
            entity.Property(e => e.Correo).HasMaxLength(100);
            entity.Property(e => e.Rol)
                .HasMaxLength(20)
                .HasDefaultValue("Secretaria");
            entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

            entity.HasOne(d => d.Usuario).WithOne(p => p.Credenciale)
                .HasForeignKey<Credenciale>(d => d.UsuarioId)
                .HasConstraintName("FK_Credenciales_Usuarios");
        });

        modelBuilder.Entity<Curso>(entity =>
        {
            entity.HasKey(e => e.CursoId).HasName("PK__Cursos__7E023A37BBC206CE");

            entity.Property(e => e.CursoId).HasColumnName("CursoID");
            entity.Property(e => e.Descripcion).HasMaxLength(255);
            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.Horario).HasMaxLength(50);
            entity.Property(e => e.NombreCurso).HasMaxLength(100);
            entity.Property(e => e.ProfesorId).HasColumnName("ProfesorID");

            entity.HasOne(d => d.Profesor).WithMany(p => p.Cursos)
                .HasForeignKey(d => d.ProfesorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cursos_Profesores");
        });

        modelBuilder.Entity<Estudiante>(entity =>
        {
            entity.HasKey(e => e.EstudianteId).HasName("PK__Estudian__6F768338E8BCC88F");

            entity.HasIndex(e => e.Email, "UQ__Estudian__A9D105342422BACE").IsUnique();

            entity.HasIndex(e => e.Cedula, "UQ__Estudian__B4ADFE38B21F4C1E").IsUnique();

            entity.Property(e => e.EstudianteId).HasColumnName("EstudianteID");
            entity.Property(e => e.Apellido).HasMaxLength(50);
            entity.Property(e => e.Cedula).HasMaxLength(20);
            entity.Property(e => e.Ciudad).HasMaxLength(50);
            entity.Property(e => e.Direccion).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Genero).HasMaxLength(10);
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.Telefono).HasMaxLength(20);
        });

        modelBuilder.Entity<Inscripcione>(entity =>
        {
            entity.HasKey(e => e.InscripcionId).HasName("PK__Inscripc__16831699FE348EF9");

            entity.HasIndex(e => new { e.EstudianteId, e.CursoId }, "UQ_Inscripcion_Unica").IsUnique();

            entity.Property(e => e.InscripcionId).HasColumnName("InscripcionID");
            entity.Property(e => e.CursoId).HasColumnName("CursoID");
            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.EstudianteId).HasColumnName("EstudianteID");
            entity.Property(e => e.FechaInscripcion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Curso).WithMany(p => p.Inscripciones)
                .HasForeignKey(d => d.CursoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Inscripciones_Cursos");

            entity.HasOne(d => d.Estudiante).WithMany(p => p.Inscripciones)
                .HasForeignKey(d => d.EstudianteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Inscripciones_Estudiantes");
        });

        modelBuilder.Entity<Profesore>(entity =>
        {
            entity.HasKey(e => e.ProfesorId).HasName("PK__Profesor__4DF3F02808DD515B");

            entity.HasIndex(e => e.Email, "UQ__Profesor__A9D105341644F692").IsUnique();

            entity.HasIndex(e => e.Cedula, "UQ__Profesor__B4ADFE38F60BCB34").IsUnique();

            entity.Property(e => e.ProfesorId).HasColumnName("ProfesorID");
            entity.Property(e => e.Apellido).HasMaxLength(50);
            entity.Property(e => e.Cedula).HasMaxLength(20);
            entity.Property(e => e.Ciudad).HasMaxLength(50);
            entity.Property(e => e.Direccion).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Especialidad).HasMaxLength(100);
            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Genero).HasMaxLength(10);
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.Telefono).HasMaxLength(20);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.UsuarioId).HasName("PK__Usuarios__2B3DE798C35FF34D");

            entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            entity.Property(e => e.Apellido).HasMaxLength(50);
            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
