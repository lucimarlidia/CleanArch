using CleanArch.Domain.Entitidades;
using CleanArch.Domain.Repositories;

namespace CleanArch.Infrastructure.Repositorios
{
    public class ProfessorRepository : BaseRepository<Professor>, IProfessorRepository    // BaseRepository implementa o Generics
    {
        public ProfessorRepository(Contexto contexto) : base(contexto)
        {
        }

        public Professor SelecionarPorId(int id)
        {
            return _contexto.Professor.FirstOrDefault(x => x.Id == id);
        }
    }
}