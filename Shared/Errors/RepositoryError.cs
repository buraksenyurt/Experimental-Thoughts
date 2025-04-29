namespace Shared.Errors;

public class RepositoryError
    : DefaultError
{
    public override string Description { get; set; } = "Repository Error";
    public string? EntityName { get; set; }
    public int? EntityId { get; set; }
}
