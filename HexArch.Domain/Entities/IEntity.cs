using HexArch.Domain.ValueObjects;

namespace HexArch.Domain.Entities;

public interface IEntity
{
    public Id Id { get; }
}