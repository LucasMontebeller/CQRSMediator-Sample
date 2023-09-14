using CQRSMediatR.Api.Application.Commands;
using CQRSMediatR.Api.Application.Models;
using CQRSMediatR.Api.Application.Notifications;
using CQRSMediatR.Repositories;
using MediatR;

namespace CQRSMediatR.Api.Application.Handlers
{
    public class CadastraCarroCommandHandler : IRequestHandler<CadastroCarroCommand, string>
    {
        private readonly IMediator _mediator;
        private readonly IRepository<Carro> _carroRepository;

        public CadastraCarroCommandHandler(IMediator mediator, IRepository<Carro> carroRepository)
        {
            _mediator = mediator;
            _carroRepository = carroRepository;
        }

        public async Task<string> Handle(CadastroCarroCommand request, CancellationToken cancellationToken)
        {
            var carro = new Carro(request.Nome, request.Valor, request.Fabricante);
            try
            {
                var id = await _carroRepository.AddAsync(carro);
                await _mediator.Publish(new CarroCriadoNotification(id, new CadastroCarroCommand(carro)));
                return await Task.FromResult("Carro criado com sucesso.");
            }
            catch (Exception ex)
            {
                await _mediator.Publish(new ErroNotification(ex.Message, ex.StackTrace));
                return await Task.FromResult("Falha ao registrar veiculo.");
            }

        }
    }
}