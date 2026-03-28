using System.Linq;
using CleanTeeth.Domain.Exceptions;

namespace CleanTeeth.Domain.ValueObjects;

public record PhoneNumber
{
    public string Value { get; } = null!;

    public PhoneNumber(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new BusinessRuleException("El número de teléfono es requerido");
        }

        var allowed = value.All(c => char.IsDigit(c) || c == '+' || c == '-' || c == '(' || c == ')' || char.IsWhiteSpace(c));

        if (!allowed)
        {
            throw new BusinessRuleException("El número de teléfono contiene caracteres inválidos. Solo se permiten dígitos y los símbolos + - ( ) y espacios");
        }

        var digitsCount = value.Count(char.IsDigit);
        if (digitsCount < 10)
        {
            throw new BusinessRuleException("El número de teléfono debe tener al menos 10 dígitos");
        }

        Value = value;
    }

}
