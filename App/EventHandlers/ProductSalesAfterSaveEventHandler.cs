using Domain.Sales;
using Shared.Contracts;
using Shared.Events;

namespace App.EventHandlers;

public class ProductSalesAfterSaveEventHandler(ILogger logger)
        : IEventHandler<AfterSaveEvent<ProductSale>>
{
    private readonly ILogger _logger = logger;

    public async Task HandleAsync(AfterSaveEvent<ProductSale> @event)
    {
        var product = @event.Entity;
        _logger.Warn($"New Product Sales After Save Action: {product.TraceId}, {product.Product.Name}, Sales price {product.Product.Price.Value}");

        await Task.CompletedTask;
    }
}
