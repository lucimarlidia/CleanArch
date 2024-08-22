﻿using CleanArch.Domain.Entitidades;
using CleanArch.Infrastructure.Mappping;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infrastructure
{
    public class Contexto : DbContext
    {
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Matricula> Matricula { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoMapping());
            modelBuilder.ApplyConfiguration(new ProfessorMapping());
            modelBuilder.ApplyConfiguration(new CursoMapping());
            modelBuilder.ApplyConfiguration(new MatriculaMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}