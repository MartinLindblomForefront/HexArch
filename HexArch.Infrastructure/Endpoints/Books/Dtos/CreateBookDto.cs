namespace HexArch.Infrastructure.Endpoints.Books.Dtos;

public record CreateBookDto(string Title, string? Description, Guid AuthorId, int PublicationYear, int PublicationMonth, int PublicationDay);