using CleanArch.Application.ViewModels;

namespace CleanArch.Application.Services
{
    public interface ICursoService
    {
        Task<int> Salvar(CursoViewModel cursoViewModel);
    }
}
