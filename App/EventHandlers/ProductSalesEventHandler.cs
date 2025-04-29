using Domain.Sales;
using Shared.Contracts;
using Shared.Events;

namespace App.EventHandlers;

public class ProductSalesEventHandler
    : IEventHandler<AfterSaveEvent<ProductSale>>
{
    public async Task HandleAsync(AfterSaveEvent<ProductSale> @event)
    {
        var product = @event.Entity;
        Console.WriteLine($"[Event] New Product Sales Notification: {product.TraceId}, {product.Product.Name}, Sales price {product.Product.Price.Value}");

        await Task.CompletedTask;
    }
}
