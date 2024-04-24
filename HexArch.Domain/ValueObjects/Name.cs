namespace HexArch.Domain.ValueObjects;

public record Name
{
    public string Value { get; private init; }

    public Name(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Value of Name must not be null nor empty/whitespace");

        Value = value;
    }
}