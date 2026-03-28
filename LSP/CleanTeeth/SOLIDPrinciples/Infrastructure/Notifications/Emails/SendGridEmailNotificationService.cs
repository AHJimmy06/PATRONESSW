using CleanTeeth.Domain.ValueObjects;

namespace SOLIDPrinciples.Infrastructure.Notifications.Emails;

public class SendGridEmailNotificationService : IEmailService
{
    public void Send(Email email, string message)
    {
        // Logica de envio...
        Console.WriteLine($"Email enviado con SendGrid para: {email.Value} con el contenido: {message}");
    }
}
           