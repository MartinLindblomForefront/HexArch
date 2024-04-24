namespace HexArch.Domain.ValueObjects;

public record PublicationDate
{
    public DateOnly Value { get; private init; }

    public PublicationDate(DateOnly value)
    {
        Value = value;
    }
}