using CleanTeeth.Domain.Entities;
using CleanTeeth.Domain.ValueObjects;
using SOLIDPrinciples.Application.Interfaces;
using SOLIDPrinciples.Application.Services;
using SOLIDPrinciples.Infrastructure.Notifications.Adapters;
using SOLIDPrinciples.Infrastructure.Notifications.Emails;
using SOLIDPrinciples.Infrastructure.Notifications.Messaging;
using SOLIDPrinciples.Infrastructure.Notifications.Sms;
using SOLIDPrinciples.Infrastructure.Notifications.Platforms;
using SOLIDPrinciples.Infrastructure.Persistence;

namespace SOLIDPrinciples;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║  PRINCIPIOS SOLID                                                      ║");
        Console.WriteLine("║  PASO 4: OPEN/CLOSE PRINCIPLE (ISP) - PRINCIPIO ABIERTO/CERRADO        ║");
        Console.WriteLine("║  Sistema CleanTeeth - REFACTORIZADO                                    ║");
        Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝\n");

        // Crear Email del paciente
        Email patientEmail = new Email("johndoe@email.com");

        // Crear Teléfono del paciente
        PhoneNumber patientPhone = new PhoneNumber("+57 300 123 4567");

        // Crear paciente
        Patient patient = new Patient("John Doe", patientEmail, patientPhone);

        // Crear Email del dentista
        Email dentistEmail = new Email("dentist@gmail.com");

        // Crear dentista
        Dentist dentist = new Dentist("Dr. Smith", dentistEmail);

        // Crear consultorio
        DentalOffice dentalOffice = new DentalOffice("Consultorio de limpieza dental");

        // Crear intervalo de tiempo
        TimeInterval timeInterval = new TimeInterval(
            DateTime.UtcNow.AddHours(1),
            DateTime.UtcNow.AddHours(2)
        );

        // Crear el repositorio de citas y el servicio de notificaciones
        IAppointmentRepository repository = new DataBaseAppointmentRepository();
        List<INotificationService> notifications = new List<INotificationService>();
        notifications.Add(new EmailNotificationService(new SmptpEmailService()));
        notifications.Add(new EmailNotificationService(new SendGridEmailNotificationService()));
        notifications.Add(new SmsNotificationService(new TwilioSmsService()));
        notifications.Add(new MessagingNotificationService(new WhatsappMessagingService()));
        notifications.Add(new PlatformNotificationService(new DiscordService()));
        notifications.Add(new PlatformNotificationService(new SlackService()));

        // Crear el servicio de citas        
        AppointmentService appointmentService = new AppointmentService(repository, notifications);

        // Agendar la cita        
        appointmentService.Schedule(patient, dentist.Id, dentalOffice.Id, timeInterval);

        Console.ReadLine();
    }  
}