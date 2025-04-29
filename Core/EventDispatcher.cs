using Microsoft.Extensions.DependencyInjection;
using Shared.Contracts;

namespace Core;

public class EventDispatcher(IServiceProvider serviceProvider, ILogger logger)
{
    private readonly IServiceProvider _serviceProvider = serviceProvider;
    private readonly ILogger _logger = logger;

    public async Task DispatchAsync<TEvent>(TEvent @event)
        where TEvent : IEvent
    {
        var handlers = _serviceProvider.GetServices<IEventHandler<TEvent>>();

        foreach (var handler in handlers)
        {
            _logger.Info($"Dispatching event of type {typeof(TEvent).Name} to handler {handler.GetType().Name}.");
            await handler.HandleAsync(@event);
        }
    }
}