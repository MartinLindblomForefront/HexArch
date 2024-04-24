using HexArch.Domain.Entities;
using HexArch.Domain.ValueObjects;

namespace HexArch.Domain.Repositories;

public interface IAuthorRepository
{
    Author? Get(Id id);
    bool Exists(Name firstName, Name lastName);
    void Save(Author author);
}