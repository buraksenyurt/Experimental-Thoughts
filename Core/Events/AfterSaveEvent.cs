using Contracts;

namespace Core.Events;

public class AfterSaveEvent<T>(T entity)
    : IBusinessEvent
{
    public T Entity { get; } = entity;
}