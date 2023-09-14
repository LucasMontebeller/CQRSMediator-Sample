using MediatR;

namespace CQRSMediatR.Api.Application.Notifications
{
    public class ErroNotification : INotification
    {
        public string Excecao { get; set; }
        public string PilhaErro { get; set; }

        public ErroNotification(string excecao, string pilhaErro)
        {
            Excecao = excecao;
            PilhaErro = pilhaErro;
        }
    }
}