using CleanArch.Domain.Entitidades;
using CleanArch.Domain.Repositories;

namespace CleanArch.Infrastructure.Repositorios
{
    public class AlunoRepository : BaseRepository<Aluno>, IAlunoRepository    // BaseRepository usa Generics
    {
        public AlunoRepository(Contexto contexto) : base(contexto)
        {
        }

        public Aluno SelecionarPorId(int id)
        {
            return _contexto.Aluno.FirstOrDefault(x => x.Id == id);
        }
    }
};
