using CleanArch.Domain.Entitidades;
using CleanArch.Domain.Repositories;

namespace CleanArch.Infrastructure.Repositorios
{
    public class CursoRepository : BaseRepository<Curso>, ICursoRepository  // BaseRepository implementa o Generics
    {
        public CursoRepository(Contexto contexto) : base(contexto)
        {
        }
    }
}