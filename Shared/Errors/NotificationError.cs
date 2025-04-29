namespace Shared.Errors;

public class NotificationError 
    : DefaultError
{
    public override string Description { get; set; } = "Notification Error";
    public string Source { get; set; }
}
