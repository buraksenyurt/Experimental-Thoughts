namespace Contracts;

public interface IEventHandler<TEvent>
    where TEvent : IBusinessEvent
{
    Task HandleAsync(TEvent @event);
}
