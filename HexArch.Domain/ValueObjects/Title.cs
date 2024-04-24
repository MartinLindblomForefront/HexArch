namespace HexArch.Domain.ValueObjects;

public record Title
{
    public string Value { get; private init; }

    public Title(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Value of Title must not be null nor empty/whitespace");

        Value = value;
    }
}