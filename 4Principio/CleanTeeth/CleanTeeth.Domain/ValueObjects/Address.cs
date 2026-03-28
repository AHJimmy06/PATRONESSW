
using System.Linq;
using CleanTeeth.Domain.Exceptions;

namespace CleanTeeth.Domain.ValueObjects;

public record Address
{
    public string Street { get; } = null!;
    public string City { get; } = null!;
    public string ZipCode { get; } = null!;

    public Address(string street, string city, string zipCode)
    {
        if (string.IsNullOrWhiteSpace(street))
        {
            throw new BusinessRuleException(
                $"El {nameof(street)} es requerido");
        }

        if (string.IsNullOrWhiteSpace(city))
        {
            throw new BusinessRuleException(
                $"El {nameof(city)} es requerido");
        }

        if (string.IsNullOrWhiteSpace(zipCode))
        {
            throw new BusinessRuleException(
                $"El {nameof(zipCode)} es requerido");
        }

        if (zipCode.Length != 5 || !zipCode.All(char.IsDigit))
        {
            throw new BusinessRuleException(
                $"El {nameof(zipCode)} debe tener exactamente 5 dígitos numéricos");
        }

        Street = street;
        City = city;
        ZipCode = zipCode;
    }

    public override string ToString() => $"{Street}, {City}, {ZipCode}";
}
