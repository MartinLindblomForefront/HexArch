namespace HexArch.Domain.ValueObjects;

public record Id
{
    public Guid Value { get; private init; }

    public Id()
    {
        Value = Guid.NewGuid();
    }

    public Id(Guid id)
    {
        Value = id;
    }
}