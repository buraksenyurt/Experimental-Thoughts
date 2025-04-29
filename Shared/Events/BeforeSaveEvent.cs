using Shared.Contracts;

namespace Shared.Events;

public class BeforeSaveEvent<T>(T entity)
    : IEvent
{
    public T Entity { get; } = entity;
}