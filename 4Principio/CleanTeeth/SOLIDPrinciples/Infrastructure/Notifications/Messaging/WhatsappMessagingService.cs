using CleanTeeth.Domain.Entities;

namespace SOLIDPrinciples.Infrastructure.Notifications.Messaging;

public class WhatsappMessagingService : IMessagingService
{
    public void Send(Patient patient)
    {
        Console.WriteLine($"Whatsapp enviado para: {patient.Name} al número: {patient.PhoneNumber.Value}");
    }
}
