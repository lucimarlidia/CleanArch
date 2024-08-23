using CleanArch.Application.ViewModels;

namespace CleanArch.Application.Services
{
    public interface IProfessorService
    {
        Task<int> Salvar(ProfessorViewModel professorViewModel);
    }
}
