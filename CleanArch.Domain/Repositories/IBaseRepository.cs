namespace CleanArch.Domain.Repositories
{
    public interface IBaseRepository<T>
    {
        void Incluir(T entity);

        void Alterar(T entity);
        T Selecionar(int id);

        List<T> SelecionarTudo();

        void Excluir(int id);
    }
}
