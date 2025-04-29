namespace Domain;

public interface IIDomainObject
{
    Guid TraceId { get; }
}