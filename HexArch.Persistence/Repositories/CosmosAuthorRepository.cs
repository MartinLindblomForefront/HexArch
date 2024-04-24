using HexArch.Domain.Entities;
using HexArch.Domain.Repositories;
using HexArch.Domain.ValueObjects;

namespace HexArch.Persistence.Repositories;

public class CosmosAuthorRepository : IAuthorRepository
{
    public bool Exists(Name firstName, Name lastName)
    {
        throw new NotImplementedException();
    }

    public Author? Get(Id id)
    {
        throw new NotImplementedException();
    }

    public void Save(Author author)
    {
        throw new NotImplementedException();
    }
}