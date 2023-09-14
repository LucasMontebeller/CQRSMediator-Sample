using CQRSMediatR.Api.Application.Commands;
using CQRSMediatR.Api.Application.Models;
using CQRSMediatR.Api.Enums;
using CQRSMediatR.Repositories;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSMediatR.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarroController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IRepository<Carro> _carroRepository;

        public CarroController(IMediator mediator, IRepository<Carro> carroRepository)
        {
            _mediator = mediator;
            _carroRepository = carroRepository;
        }

        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _carroRepository.GetAllAsync());
        }

        [HttpGet]
        [Route("Get/{id}")]
        public async Task<IActionResult> GetAsync(Guid id)
        {
            return Ok(await _carroRepository.GetBydIdAsync(id));
        }

        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> PostAsync(CadastroCarroCommand cadastroCarroCommand)
        {
            var response = await _mediator.Send(cadastroCarroCommand);
            return Ok(response);
        }

        [HttpPost]
        [Route("Remove")]
        public async Task<IActionResult> DeleteAsync(ExcluiCarroCommand excluiCarroCommand)
        {
            var response = await _mediator.Send(excluiCarroCommand);
            return Ok(response);
        }
    }
}