using Shared.Contracts;
using Shared.Events;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Core;

public class BeforeSaveEventHandler<T>(ILogger logger)
    : IEventHandler<BeforeSaveEvent<T>>
{
    private readonly ILogger _logger = logger;

    public async Task HandleAsync(BeforeSaveEvent<T> @event)
    {
        var entity = @event.Entity;

        _logger.Warn($"[Before Save] Type: {typeof(T).Name}, Data: {JsonSerializer.Serialize(entity)}");

        if (entity is IValidatable validatable)
        {
            validatable.Validate();
        }

        await Task.CompletedTask;
    }
}

