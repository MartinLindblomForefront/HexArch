using HexArch.Domain.Entities;
using HexArch.Domain.Repositories;
using HexArch.Domain.ValueObjects;

namespace HexArch.Domain.Services;

public interface IBookService
{
    Book Create(Title title, Description? description, Id authorId, PublicationDate publicationDate);
}

public class BookService(IBookRepository BookRepository, IAuthorRepository AuthorRepository) : IBookService
{
    public Book Create(Title title, Description? description, Id authorId, PublicationDate publicationDate)
    {
        if (AuthorRepository.Get(authorId) == null)
            throw new InvalidOperationException($"Author with Id '{authorId}' does not exist");

        if (BookRepository.Exists(title))
            throw new InvalidOperationException($"Book with Title '{title}' already exists.");

        return new Book(new Id(), title, description, authorId, publicationDate);
    }
}