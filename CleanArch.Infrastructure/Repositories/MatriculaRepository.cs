﻿using CleanArch.Domain.Entitidades;
using CleanArch.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infrastructure.Repositorios
{
    public class MatriculaRepository : BaseRepository<Matricula>, IMatriculaRepository
    {
        public MatriculaRepository(Contexto contexto) : base(contexto)
        {                
        }

        public List<Matricula> SelecionarTudoCompleto()
        {
            return _contexto.Matricula
                .Include(x => x.Aluno)
                .Include(x => x.Curso)
                //.ThenInclude(x => x.Professor)   // ThenInclude é usada, pois o Porfessor está referenciada na classe Curso
                .ToList();
        }
    }
}