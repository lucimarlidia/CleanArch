using CleanArch.Application.Services;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : ControllerBase
    {
        private readonly ICursoService _service;

        public CursoController(ICursoService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CursoViewModel cursoViewModel)
        {
            if (cursoViewModel == null)
            {
                return BadRequest("Dados inválidos.");
            }

            try
            {
                var cursoId = await _service.Salvar(cursoViewModel);
                return Ok(new { Message = "Curso salvo com sucesso!", CursoId = cursoId });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao salvar o curso: {ex.Message}");
            }
        }
    }
}

