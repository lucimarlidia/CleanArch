
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Entitidades;

namespace CleanArch.Application.Services
{
    public interface IAlunoService
    {
        Task<IEnumerable<Aluno>> SelecionarTudo();
        Task<AlunoViewModel> Selecionar(int id);
        Task<int> Salvar(AlunoViewModel alunoViewModel);
        Task<AlunoViewModel> Atualizar(AlunoViewModel alunoViewModel);
        Task<bool> Excluir(int id);
    }
}
