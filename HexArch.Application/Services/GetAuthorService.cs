using HexArch.Domain.Entities;
using HexArch.Domain.Repositories;
using HexArch.Domain.ValueObjects;

namespace HexArch.Application.Services;

public interface IGetAuthorService
{
    Author? Get(Guid id);
}

public class GetAuthorService(IAuthorRepository AuthorRepository) : IGetAuthorService
{
    public Author? Get(Guid id)
        => AuthorRepository.Get(new Id(id));
}