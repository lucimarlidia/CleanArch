
using CleanArch.Application.ViewModels;

namespace CleanArch.Application.Services
{
    public interface IAlunoService
    {
        Task Salvar(AlunoViewModel alunoViewModel);
    }
}
