namespace HexArch.Persistence.Models;

public record BookModel
{
    public required Guid Id { get; set; }
    public required string Title { get; set; }
    public string? Description { get; set; }
    public required Guid AuthorId { get; set; }
    public required int PublicationYear { get; set; }
    public required int PublicationMonth { get; set; }
    public required int PublicationDay { get; set; }
}