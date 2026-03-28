using CleanTeeth.Domain.ValueObjects;
using SOLIDPrinciples.Application.Interfaces;

namespace SOLIDPrinciples.Infrastructure.Notifications.Emails;

public interface IEmailService 
{
    void Send(Email email, string message);
}
