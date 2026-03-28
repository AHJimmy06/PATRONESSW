using CleanTeeth.Domain.Entities;

namespace SOLIDPrinciples.Infrastructure.Notifications.Platforms;

public class SlackService : IPlatformService
{
    public void Send(Patient patient)
    {
        Console.WriteLine($"Notificación de Slack enviada a: {patient.Name}");
    }
}
