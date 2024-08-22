using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using CleanArch.Domain.Entitidades;


namespace CleanArch.Infrastructure.Mappping
{
    public class MatriculaMapping : IEntityTypeConfiguration<Matricula>
    {
        public void Configure(EntityTypeBuilder<Matricula> builder)
        {
            builder.ToTable("Matricula");

            builder.HasKey(x => new { x.IdCurso, x.IdAluno});

            builder.HasOne(x => x.Curso)
                .WithMany(x => x.Matriculas)
                .HasForeignKey(x => x.IdCurso);

            builder.HasOne(x => x.Aluno)
                .WithMany(x => x.Matriculas)
                .HasForeignKey(x => x.IdAluno);

            builder.Property(x => x.Id)
                .UseIdentityColumn();
        }
    }
}

