using CleanArch.Domain.Entitidades;
using CleanArch.Domain.Repositories;

namespace CleanArch.Infrastructure.Repositorios
{
    public class AlunoRepository : BaseRepository<Aluno>, IAlunoRepository    // BaseRepository usa Generics
    {
        public AlunoRepository(Contexto contexto) : base(contexto)
        {
        }
    }
};
