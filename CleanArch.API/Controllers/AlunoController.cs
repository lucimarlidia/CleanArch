using CleanArch.Application.Services;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoService _service;

        public AlunoController(IAlunoService service)
        {
            _service = service;
        }


        [HttpPost]
        public void Post([FromBody] AlunoViewModel alunoViewModel)
        {
            _service.Salvar(alunoViewModel);
        }
    }
}
