using MediatR;

namespace CQRSMediatR.Api.Application.Commands
{
    public class ExcluiCarroCommand : IRequest<string>
    {
        public Guid Id { get; set; }
    }
}