using Shared.Contracts;

namespace Shared.Events;

public class AfterSaveEvent<T>(T entity)
    : IEvent
{
    public T Entity { get; } = entity;
}