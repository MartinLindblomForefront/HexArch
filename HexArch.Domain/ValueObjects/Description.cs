namespace HexArch.Domain.ValueObjects;

public record Description
{
    public string Value { get; private init; }

    public Description(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Value of Name must not be null nor empty/whitespace");

        Value = value;
    }
}