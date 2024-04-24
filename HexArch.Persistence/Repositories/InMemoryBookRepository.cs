using HexArch.Domain.Entities;
using HexArch.Domain.Repositories;
using HexArch.Domain.ValueObjects;
using HexArch.Persistance.Mappers;
using HexArch.Persistence.Models;

namespace HexArch.Persistence.Repositories;

public class InMemoryBookRepository : IBookRepository
{
    private IEnumerable<BookModel> inMemoryBooks = [];

    public Book? Get(Id id)
    {
        var model = inMemoryBooks.SingleOrDefault(book => book.Id == id.Value);
        if (model != null)
            return BookModelMapper.FromModel(model);

        return null;
    }

    public bool Exists(Title title)
    {
        return inMemoryBooks.Any(b => b.Title == title.Value);
    }

    public void Save(Book book)
    {
        inMemoryBooks = inMemoryBooks.Append(BookModelMapper.FromEntity(book));
    }
}