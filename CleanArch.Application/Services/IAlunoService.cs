
using CleanArch.Application.ViewModels;

namespace CleanArch.Application.Services
{
    public interface IAlunoService
    {
        Task<int> Salvar(AlunoViewModel alunoViewModel);
    }
}
