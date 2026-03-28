using SOLIDPrinciples.Application.Interfaces;
using SOLIDPrinciples.Infrastructure.Notifications.Emails;
using SOLIDPrinciples.Infrastructure.Notifications.Messaging;
using SOLIDPrinciples.Infrastructure.Notifications.Sms;
using System;
using System.Collections.Generic;
using System.Text;
using CleanTeeth.Domain.Entities;

namespace SOLIDPrinciples.Infrastructure.Notifications.Adapters;

public class EmailNotificationService : INotificationService
{
    private readonly IEmailService _emailService;
    private readonly SmptpEmailService _smtpEmailService;

    //Inyec
    public EmailNotificationService(IEmailService emailService)
    {
        _emailService = emailService;
    }
    public void Send(Patient patient, string message) {
        _emailService.Send(patient.Email, message);
    }


}
