﻿using CleanArch.Domain.Entitidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArch.Infrastructure.Mappping
{
    public class AlunoMapping : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Aluno");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasColumnType("nvarchar(150)")
                .IsRequired();

            builder.Property(x => x.Endereco)
                .HasColumnType("nvarchar(200)")
                .IsRequired();

            builder.Property(x => x.Email)
                .HasColumnType("nvarchar(100)")
                .IsRequired();

            builder.Property(x => x.Ativo)
                .HasColumnType("bit")
                .IsRequired();
        }
    }
}