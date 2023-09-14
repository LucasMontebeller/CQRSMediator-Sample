using CQRSMediatR.Api.Application.Commands;
using MediatR;

namespace CQRSMediatR.Api.Application.Notifications
{
    public class CarroCriadoNotification : INotification
    {
        public Guid Id { get; set; }
        public CadastroCarroCommand CadastroCarroCommand { get; set; }

        public CarroCriadoNotification(Guid id, CadastroCarroCommand cadastroCarroCommand)
        {
            Id = id;
            CadastroCarroCommand = cadastroCarroCommand;
        }
    }
}