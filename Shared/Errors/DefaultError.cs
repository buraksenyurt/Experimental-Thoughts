namespace Shared.Errors;

public class DefaultError
{
    public virtual string Description { get; set; } = "Standard Error";
    public virtual string? Message { get; set; }
    public virtual string? Action { get; set; }
}
