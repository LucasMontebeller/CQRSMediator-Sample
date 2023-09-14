using MediatR;

namespace CQRSMediatR.Api.Application.Notifications
{
    public class CarroRemovidoNotification : INotification
    {
        public Guid Id { get; set; }

        public CarroRemovidoNotification(Guid id)
        {
            Id = id;
        }
    }
}