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

        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> Post(CadastroCarroCommand cadastroCarroCommand)
        {
            var response = await _mediator.Send(cadastroCarroCommand);
            return Ok(response);
        }
    }
}