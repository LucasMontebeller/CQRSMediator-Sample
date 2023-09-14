using CQRSMediatR.Api.Abstraction;
using CQRSMediatR.Api.Enums;

namespace CQRSMediatR.Api.Application.Models
{
    public class Carro : EntityBase
    {
        public Decimal Valor { get; set; }
        public EFabricante Fabricante { get; set; }

        public Carro(string nome, Decimal valor, EFabricante fabricante) : base(nome)
        {
            Valor = valor;
            Fabricante = fabricante; 
        }
    }
}