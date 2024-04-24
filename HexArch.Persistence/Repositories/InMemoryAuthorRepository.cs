using HexArch.Domain.Entities;
using HexArch.Domain.Repositories;
using HexArch.Domain.ValueObjects;
using HexArch.Persistence.Mappers;
using HexArch.Persistence.Models;

namespace HexArch.Persistence.Repositories;

public class InMemoryAuthorRepository : IAuthorRepository
{
    private IEnumerable<AuthorModel> inMemoryAuthors = [];

    public Author? Get(Id id)
    {
        var model = inMemoryAuthors.SingleOrDefault(a => a.Id == id.Value);
        if (model != null)
            return AuthorModelMapper.FromModel(model);

        return null;
    }

    public bool Exists(Name firstName, Name lastName)
    {
        return inMemoryAuthors.Any(a => a.FirstName == firstName.Value && a.LastName == lastName.Value);
    }

    public void Save(Author author)
    {
        inMemoryAuthors = inMemoryAuthors.Append(AuthorModelMapper.FromEntity(author));
    }
}