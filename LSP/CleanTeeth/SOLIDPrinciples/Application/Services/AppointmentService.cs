using CleanTeeth.Domain.Entities;
using CleanTeeth.Domain.ValueObjects;
using SOLIDPrinciples.Application.Interfaces;
using SOLIDPrinciples.Infrastructure.Notifications;
using SOLIDPrinciples.Infrastructure.Notifications.Emails;
using SOLIDPrinciples.Infrastructure.Notifications.Messaging;
using SOLIDPrinciples.Infrastructure.Notifications.Sms;
using SOLIDPrinciples.Infrastructure.Persistence;

namespace SOLIDPrinciples.Application.Services;

public class AppointmentService
{
    private List<Appointment> _appointments = new List<Appointment>();

    private readonly IAppointmentRepository _repository; 
    private readonly IEnumerable<INotificationService> _notifications;

    public AppointmentService(
     IAppointmentRepository repository,
     IEnumerable<INotificationService> notifications
    )
    {
        _repository = repository;
        _notifications = notifications;
    }

    public void Schedule(Patient patient, Guid dentistId, Guid dentalOfficeId, TimeInterval timeInterval)
    {
        Console.WriteLine("Programar cita...");

        // VALIDACIÓN REGLA DE NEGOCIO: Verificar que el dentista no tenga otra cita en el mismo horario (AHORA SE HACE EN EL CONSTRUCTOR)
        var appointment = new Appointment(patient.Id, dentistId, dentalOfficeId, timeInterval, _appointments);

        // AGREGAR LA CITA AL LISTADO DE CITAS
        _appointments.Add(appointment);

        // GUARDAR EN ARCHIVO
        _repository.Save(appointment);

        // ENVIAR LAS NOTIFICACIONES
        foreach (var notification in _notifications)
        {
            notification.Send(patient, "Cita Programada");
        }



        // VISUALIZAR MENSAJE DE CONFIRMACIÓN
        Console.WriteLine("Cita programada con éxito.");
    }
}
