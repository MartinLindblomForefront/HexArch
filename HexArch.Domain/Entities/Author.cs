using HexArch.Domain.ValueObjects;

namespace HexArch.Domain.Entities;

public record Author(Id Id, Name FirstName, Name LastName) : IEntity;