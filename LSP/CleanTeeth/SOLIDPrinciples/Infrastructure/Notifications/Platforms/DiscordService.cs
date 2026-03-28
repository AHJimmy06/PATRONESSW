using CleanTeeth.Domain.Entities;

namespace SOLIDPrinciples.Infrastructure.Notifications.Platforms;

public class DiscordService : IPlatformService
{
    public void Send(Patient patient, string message)
    {
        Console.WriteLine($"Notificación de Discord enviada a: {patient.Name} con el contenido: {message}");
    }
}
