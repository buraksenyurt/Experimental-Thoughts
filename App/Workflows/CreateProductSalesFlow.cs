using Core;
using Microsoft.Extensions.DependencyInjection;
using Shared.Contracts;
using Shared.Events;

namespace App.Workflows;

// Daha generic hali ile Core'dan karşılanabilir mi?
public class CreateProductSalesFlow(IServiceProvider serviceProvider, ILogger logger)
{
    private readonly IServiceProvider _serviceProvider = serviceProvider;
    private readonly ILogger _logger = logger;
    public async Task SaveAsync<T>(T entity)
    {
        _logger.Info($"Saving {typeof(T).Name}...");

        //var hasAfterSave = typeof(T).GetCustomAttributes(typeof(AfterSaveAttribute), inherit: true).Length != 0;
        //if (hasAfterSave)
        //{
        var dispatcher = _serviceProvider.GetRequiredService<EventDispatcher>();
        await dispatcher.DispatchAsync(new BeforeSaveEvent<T>(entity));

        _logger.Info("Some save operations");

        await dispatcher.DispatchAsync(new AfterSaveEvent<T>(entity));
        //}
        //else
        //{
        //    _logger.Info($"{typeof(T).Name} has no AfterSave attribute. Skipping push.");
        //}
    }
}