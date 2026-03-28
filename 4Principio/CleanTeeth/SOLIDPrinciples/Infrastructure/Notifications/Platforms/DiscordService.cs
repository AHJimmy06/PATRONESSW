using CleanTeeth.Domain.Entities;

namespace SOLIDPrinciples.Infrastructure.Notifications.Platforms;

public class DiscordService : IPlatformService
{
    public void Send(Patient patient)
    {
        Console.WriteLine($"Notificación de Discord enviada a: {patient.Name}");
    }
}
