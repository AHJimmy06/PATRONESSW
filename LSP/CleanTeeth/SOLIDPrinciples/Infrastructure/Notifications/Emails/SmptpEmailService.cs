using CleanTeeth.Domain.ValueObjects;

namespace SOLIDPrinciples.Infrastructure.Notifications.Emails;

//implementacion
public class SmptpEmailService : IEmailService
{
    public void Send(Email email, string message)
    {
        // Logica de envio...
        Console.WriteLine($"Email enviado para: {email.Value} con el contenido: {message}");
    }
}
