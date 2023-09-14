using CQRSMediatR.Api.Application.Models;
using CQRSMediatR.Api.Enums;
using MediatR;

namespace CQRSMediatR.Api.Application.Commands
{
    public class CadastroCarroCommand : IRequest<string>
    {
        public string Nome { get; set; }
        public Decimal Valor { get; set; }
        public EFabricante Fabricante { get; set; }

        public CadastroCarroCommand()
        { }

        public CadastroCarroCommand(string nome, Decimal valor, EFabricante fabricante)
        {
            Nome = nome;
            Valor = valor;
            Fabricante = fabricante;
        }

        public CadastroCarroCommand(Carro carro)
        {
            Nome = carro.Nome;
            Valor = carro.Valor;
            Fabricante = carro.Fabricante;
        }
    }
}