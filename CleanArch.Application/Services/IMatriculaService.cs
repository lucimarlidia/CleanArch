using CleanArch.Application.ViewModels;

namespace CleanArch.Application.Services
{
    public interface IMatriculaService
    {
        Task<int> Salvar(MatriculaViewModel matriculaViewModel);
    }
}
