using CQRSMediatR.Api.Application.Enums;
using CQRSMediatR.Api.Application.Models;
using CQRSMediatR.Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CQRSMediatR.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarroController : ControllerBase
    {
        // Para a POC, não há necessidade de usar uma injeção de interface ou ServiceProvider
        private readonly static CarroRepository _carroRepository = new();

        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> InsertSample()
        {
            var success = await _carroRepository.AddAsync(new Carro("Civic Si 2008", 70000, EFabricante.Honda));
            if (!success)
                return BadRequest("Falha ao inserir o registro !");    
            return Ok("Registro inserido com sucesso !");
        }
    }
}