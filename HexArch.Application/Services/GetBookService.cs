using HexArch.Domain.Entities;
using HexArch.Domain.Repositories;
using HexArch.Domain.ValueObjects;

namespace HexArch.Application.Services;

public interface IGetBookService
{
    Book? Get(Guid Id);
}

public class GetBookService(IBookRepository BookRepository) : IGetBookService
{
    public Book? Get(Guid Id)
        => BookRepository.Get(new Id(Id));
}