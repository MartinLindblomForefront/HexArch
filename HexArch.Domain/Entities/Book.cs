using HexArch.Domain.ValueObjects;

namespace HexArch.Domain.Entities;

public record Book(Id Id, Title Title, Description? Description, Id AuthorId, PublicationDate PublicationDate) : IEntity;