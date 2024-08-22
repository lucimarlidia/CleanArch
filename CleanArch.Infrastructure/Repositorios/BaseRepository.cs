using CleanArch.Domain.Entitidades;
using CleanArch.Domain.Repositories;

namespace CleanArch.Infrastructure.Repositorios
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, IEntity  // nesta classe é usada Generics
    {
        protected readonly Contexto _contexto;

        public BaseRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        public void Incluir(T entity)
        {
            _contexto.Set<T>().Add(entity);
            _contexto.SaveChanges();
        }

        public void Alterar(T entity)
        {
            _contexto.Set<T>().Update(entity);
            _contexto.SaveChanges();
        }
        public T Selecionar(int id)
        {
            return _contexto.Set<T>().FirstOrDefault(x => x.Id == id);
        }

        public List<T> SelecionarTudo()
        {
            return _contexto.Set<T>().ToList();
        }

        public void Excluir(int id)
        {
            var entity = Selecionar(id);
            _contexto.Set<T>().Remove(entity);
            _contexto.SaveChanges();
        }
        public void Dispose()    // libera espaço na memória (executa o garbage colector)
        {
            _contexto.Dispose();
        }
    }
}