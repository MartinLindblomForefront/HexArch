using HexArch.Application.Services;
using HexArch.Infrastructure.Endpoints.Books.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace HexArch.Infrastructure.Endpoints.Books;

[ApiController]
[Route("api/[controller]")]
public class BookController(LinkGenerator LinkGenerator, IGetBookService GetBookService, ICreateBookService CreateBookService) : ControllerBase
{
    [HttpGet("{id}", Name = "GetBookById")]
    public IActionResult Get(Guid id)
    {
        var book = GetBookService.Get(id);
        if (book == null)
            return NotFound();

        return Ok(book);
    }

    [HttpPost]
    public IActionResult Create([FromBody] CreateBookDto dto)
    {
        var book = CreateBookService.Create(dto.Title, dto.Description, dto.AuthorId, new DateOnly(dto.PublicationYear, dto.PublicationMonth, dto.PublicationDay));

        var resourceUrl = LinkGenerator.GetUriByName(HttpContext, "GetBookById", new { id = book.Id.Value.ToString() });

        return Created(resourceUrl, CreateBookReturnDto.FromEntity(book));
    }
}