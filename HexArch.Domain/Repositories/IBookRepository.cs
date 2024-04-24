using HexArch.Domain.Entities;
using HexArch.Domain.ValueObjects;

namespace HexArch.Domain.Repositories;

public interface IBookRepository
{
    Book? Get(Id id);
    bool Exists(Title title);
    void Save(Book book);
}