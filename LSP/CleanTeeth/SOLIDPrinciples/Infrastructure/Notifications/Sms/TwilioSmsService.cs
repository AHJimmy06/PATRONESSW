using CleanTeeth.Domain.Entities;
using CleanTeeth.Domain.ValueObjects;

namespace SOLIDPrinciples.Infrastructure.Notifications.Sms;

public class TwilioSmsService : ISmsService
{
    public void Send(Patient patient, string message)
    {
        // Logica de envio...
        Console.WriteLine($"SMS enviado con Twilio para: {patient.Name} al número: {patient.PhoneNumber.Value} con el contenido: {message}");
    }
}
