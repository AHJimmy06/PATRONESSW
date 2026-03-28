using CleanTeeth.Domain.Entities;

namespace SOLIDPrinciples.Infrastructure.Notifications.Messaging;

public interface IMessagingService
{
    public void Send(Patient patient, string messsage);
}
