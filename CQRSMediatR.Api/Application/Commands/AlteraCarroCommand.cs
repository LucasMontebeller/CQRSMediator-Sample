using CQRSMediatR.Api.Enums;
using MediatR;

namespace CQRSMediatR.Api.Application.Commands
{
    public class AlteraCarroCommand : CadastroCarroCommand, IRequest<string>
    {
        public Guid Id { get; set; }

        public AlteraCarroCommand(string nome, Decimal valor, EFabricante fabricante) : base(nome, valor, fabricante)
        { }
    }
}