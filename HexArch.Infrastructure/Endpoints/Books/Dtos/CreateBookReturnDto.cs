using HexArch.Domain.Entities;

namespace HexArch.Infrastructure.Endpoints.Books.Dtos;

public record CreateBookReturnDto(Guid Id, string Title, string? Description, Guid AuthorId, int PublicationYear, int PublicationMonth, int PublicationDay)
{
    public static CreateBookReturnDto FromEntity(Book book)
    {
        return new CreateBookReturnDto(
            book.Id.Value,
            book.Title.Value,
            book.Description?.Value,
            book.AuthorId.Value,
            book.PublicationDate.Value.Year,
            book.PublicationDate.Value.Month,
            book.PublicationDate.Value.Day
        );
    }
}