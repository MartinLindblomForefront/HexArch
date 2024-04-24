using HexArch.Domain.Entities;
using HexArch.Domain.ValueObjects;
using HexArch.Persistence.Models;

namespace HexArch.Persistance.Mappers;

public class BookModelMapper
{
    public static BookModel FromEntity(Book entity)
    {
        return new BookModel()
        {
            Id = entity.Id.Value,
            Title = entity.Title.Value,
            Description = entity.Description?.Value,
            AuthorId = entity.AuthorId.Value,
            PublicationYear = entity.PublicationDate.Value.Year,
            PublicationMonth = entity.PublicationDate.Value.Month,
            PublicationDay = entity.PublicationDate.Value.Day
        };
    }

    public static Book FromModel(BookModel model)
    {
        var description = model.Description == null ? null : new Description(model.Description);

        return new Book(
            new Id(model.Id),
            new Title(model.Title),
            description,
            new Id(model.AuthorId),
            new PublicationDate(new DateOnly(model.PublicationYear, model.PublicationMonth, model.PublicationDay))
        );
    }
}