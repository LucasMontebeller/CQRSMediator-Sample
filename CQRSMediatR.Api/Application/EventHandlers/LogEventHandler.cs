using CQRSMediatR.Api.Application.Notifications;
using MediatR;

namespace CQRSMediatR.Api.Application.EventHandlers
{
    public class LogEventHandler : 
        INotificationHandler<CarroCriadoNotification>,
        INotificationHandler<ErroNotification>
    {
        public Task Handle(CarroCriadoNotification notification, CancellationToken cancellationToken)
        {
            var carro = notification.CadastroCarroCommand;
            return Task.Run(() => {
                Console.WriteLine($"CRIAÇÃO : {notification.Id} - {carro.Nome} - {carro.Valor} - {carro.Fabricante}");
            }, cancellationToken);
        }

        public Task Handle(ErroNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() => {
                Console.WriteLine($"ERRO : {notification.Excecao} - {notification.PilhaErro}");
            }, cancellationToken);
        }
    }
}