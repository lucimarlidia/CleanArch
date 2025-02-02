﻿using CleanArch.Application.ViewModels;

namespace CleanArch.Application.Services
{
    public interface ICursoService
    {
        Task<int> Salvar(CursoViewModel cursoViewModel);
        Task<CursoViewModel> Selecionar(int id);
        Task<IEnumerable<CursoViewModel>> SelecionarTudo();
        Task<CursoViewModel> Atualizar(CursoViewModel cursoViewModel);
        Task<bool> Excluir(int id);
    }
}
