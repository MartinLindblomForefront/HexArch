namespace HexArch.Persistence.Models;

public record AuthorModel
{
    public required Guid Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
}