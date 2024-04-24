using HexArch.Domain.Entities;
using HexArch.Domain.ValueObjects;
using HexArch.Persistence.Models;

namespace HexArch.Persistence.Mappers;

public class AuthorModelMapper
{
    public static AuthorModel FromEntity(Author entity)
    {
        return new AuthorModel()
        {
            Id = entity.Id.Value,
            FirstName = entity.FirstName.Value,
            LastName = entity.LastName.Value,
        };
    }

    public static Author FromModel(AuthorModel model)
    {
        return new Author(
            new Id(model.Id),
            new Name(model.FirstName),
            new Name(model.LastName)
        );
    }
}