using HexArch.Application.Services;
using HexArch.Infrastructure.Endpoints.Authors.Dtos;
using HexArch.Infrastructure.Endpoints.Books.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace HexArch.Infrastructure.Endpoints.Authors;

[ApiController]
[Route("api/[controller]")]
public class AuthorController(LinkGenerator LinkGenerator, ICreateAuthorService CreateAuthorService, IGetAuthorService GetAuthorService) : ControllerBase
{
    [HttpGet("{id}", Name = "GetAuthorById")]
    public IActionResult Get(Guid id)
    {
        var author = GetAuthorService.Get(id);
        if (author == null)
            return NotFound();

        return Ok(author);
    }

    [HttpPost]
    public IActionResult Create([FromBody] CreateAuthorDto dto)
    {
        var author = CreateAuthorService.Create(dto.FirstName, dto.LastName);

        var resourceUrl = LinkGenerator.GetUriByName(HttpContext, "GetAuthorById", new { id = author.Id.Value.ToString() });

        return Created(resourceUrl, CreateAuthorReturnDto.FromEntity(author));
    }
}