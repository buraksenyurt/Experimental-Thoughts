using Shared.Contracts;
using Shared.Events;
using System.Text.Json;

namespace Core;

public class AfterSaveEventHandler<T>(ILogger logger)
    : IEventHandler<AfterSaveEvent<T>>
{
    private readonly ILogger _logger = logger;

    public async Task HandleAsync(AfterSaveEvent<T> @event)
    {
        var entity = @event.Entity;

        _logger.Warn($"[After Save] Type: {typeof(T).Name}, Data: {JsonSerializer.Serialize(entity)}");

        // Audit, Cache Temizleme işlemleri burada yapılabilir.
        if (entity is ITrackable trackable)
        {
            trackable.TrackChanges();
        }

        await Task.CompletedTask;
    }
}
