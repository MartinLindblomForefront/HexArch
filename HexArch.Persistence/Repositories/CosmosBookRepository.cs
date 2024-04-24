using HexArch.Domain.Entities;
using HexArch.Domain.Repositories;
using HexArch.Domain.ValueObjects;

namespace HexArch.Persistence.Repositories;

public class CosmosBookRepository : IBookRepository
{
    public bool Exists(Title title)
    {
        throw new NotImplementedException();
    }

    public void Save(Book book)
    {
        throw new NotImplementedException();
    }

    Book? IBookRepository.Get(Id id)
    {
        throw new NotImplementedException();
    }
}