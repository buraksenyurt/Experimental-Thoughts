using Domain.Sales;
using Shared.Contracts;
using Shared.Events;

namespace App.EventHandlers;

public class ProductSalesBeforeSaveEventHandler(ILogger logger)
        : IEventHandler<BeforeSaveEvent<ProductSale>>
{
    private readonly ILogger _logger = logger;

    public async Task HandleAsync(BeforeSaveEvent<ProductSale> @event)
    {
        var product = @event.Entity;
        _logger.Warn($"[Event] New Product Sales Before Save Action: {product.TraceId}, {product.Product.Name}, Sales price {product.Product.Price.Value}");

        await Task.CompletedTask;
    }
}
