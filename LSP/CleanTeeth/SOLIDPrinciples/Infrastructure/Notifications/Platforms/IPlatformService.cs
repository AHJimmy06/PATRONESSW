using CleanTeeth.Domain.Entities;

namespace SOLIDPrinciples.Infrastructure.Notifications.Platforms;

public interface IPlatformService
{
    void Send(Patient patient, string message);
}
