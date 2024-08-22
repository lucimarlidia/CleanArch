using CleanArch.Application.ViewModels;
using CleanArch.Domain.Entitidades;
using CleanArch.Domain.Repositories;

namespace CleanArch.Application.Services
{
    public class AlunoService : IAlunoService
    {
        private readonly IAlunoRepository _alunoRepository;
        public async Task Salvar(AlunoViewModel alunoViewModel)
        {
            var aluno = alunoViewModel.Id != null
                ? _alunoRepository.Selecionar(alunoViewModel.Id.Value)
                : null;

            if (aluno == null)
            {
                InserirAluno(alunoViewModel);
                return;
            }
            AtualizarAluno(aluno, alunoViewModel);
        }


        private void InserirAluno(AlunoViewModel alunoViewModel)
        {
            var aluno = new Aluno
            {
                Nome = alunoViewModel.Nome,
                Endereco = alunoViewModel.Endereco,
                Email = alunoViewModel.Email,
                Ativo = true
            };
            _alunoRepository.Incluir(aluno);
        }
        private void AtualizarAluno(Aluno aluno, AlunoViewModel alunoViewModel)
        {
            aluno.Nome = alunoViewModel.Nome;
            aluno.Endereco = alunoViewModel.Endereco;
            aluno.Email = alunoViewModel.Email;
            aluno.Ativo = alunoViewModel.Ativo;
            _alunoRepository.Alterar(aluno);
        }
    }
}
