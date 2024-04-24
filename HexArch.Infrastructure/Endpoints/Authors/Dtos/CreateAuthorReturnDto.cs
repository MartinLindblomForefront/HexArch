using HexArch.Domain.Entities;

namespace HexArch.Infrastructure.Endpoints.Books.Dtos;

public record CreateAuthorReturnDto(Guid Id, string FirstName, string LastName)
{
    public static CreateAuthorReturnDto FromEntity(Author author)
    {
        return new CreateAuthorReturnDto(
            author.Id.Value,
            author.FirstName.Value,
            author.LastName.Value
        );
    }
}