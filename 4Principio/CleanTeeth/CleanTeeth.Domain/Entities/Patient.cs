using CleanTeeth.Domain.Exceptions;
using CleanTeeth.Domain.ValueObjects;

namespace CleanTeeth.Domain.Entities;

public class Patient
{
    public Guid Id { get; private set; }
    public string Name { get; private set; } = null!;
    public Email Email { get; private set; } = null!;
    public PhoneNumber PhoneNumber { get; private set; } = null!;

    public Patient(string name, Email email, PhoneNumber phoneNumber)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new BusinessRuleException($"El {nameof(name)} es requerido");
        }

        if (email is null)
        {
            throw new BusinessRuleException($"El {nameof(email)} es requerido");
        }

        if (phoneNumber is null)
        {
            throw new BusinessRuleException($"El {nameof(phoneNumber)} es requerido");
        }

        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
        Id = Guid.CreateVersion7();
    }
}
