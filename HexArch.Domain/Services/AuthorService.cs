using HexArch.Domain.Entities;
using HexArch.Domain.Repositories;
using HexArch.Domain.ValueObjects;

namespace HexArch.Domain.Services;

public interface IAuthorService
{
    Author Create(Name firstName, Name lastName);
}

public class AuthorService(IAuthorRepository AuthorRepository) : IAuthorService
{
    public Author Create(Name firstName, Name lastName)
    {
        if (AuthorRepository.Exists(firstName, lastName))
            throw new InvalidOperationException($"Author with first name '{firstName}' and last name '{lastName}' already exists");

        return new Author(new Id(), firstName, lastName);
    }
}