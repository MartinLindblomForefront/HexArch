using HexArch.Domain.Entities;
using HexArch.Domain.Repositories;
using HexArch.Domain.Services;
using HexArch.Domain.ValueObjects;

namespace HexArch.Application.Services;

public interface ICreateAuthorService
{
    Author Create(string firstName, string lastName);
}

public class CreateAuthorService(IAuthorService AuthorService, IAuthorRepository AuthorRepository) : ICreateAuthorService
{
    public Author Create(string firstName, string lastName)
    {
        var author = AuthorService.Create(new Name(firstName), new Name(lastName));

        AuthorRepository.Save(author);

        return author;
    }
}