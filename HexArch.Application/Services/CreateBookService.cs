using HexArch.Domain.Entities;
using HexArch.Domain.Repositories;
using HexArch.Domain.Services;
using HexArch.Domain.ValueObjects;

namespace HexArch.Application.Services;

public interface ICreateBookService
{
    Book Create(string title, string? description, Guid authorId, DateOnly publicationDate);
}

public class CreateBookService(IBookService BookService, IBookRepository BookRepository) : ICreateBookService
{
    public Book Create(string title, string? description, Guid authorId, DateOnly publicationDate)
    {
        var desc = description == null ? null : new Description(description);

        var book = BookService.Create(
            new Title(title),
            desc,
            new Id(authorId),
            new PublicationDate(publicationDate)
        );

        BookRepository.Save(book);

        return book;
    }
}