using App;
using App.EventHandlers;
using App.Workflows;
using Contracts;
using Core;
using Core.Events;
using Domain.Common;
using Domain.Sales;
using Microsoft.Extensions.DependencyInjection;

internal class Program
{
    private static async Task Main()
    {
        var services = new ServiceCollection();

        services.AddSingleton<EventDispatcher>();
        services.AddTransient<ILogger, Logger>();
        services.AddTransient<IEventHandler<AfterSaveEvent<ProductSale>>, ProductSalesEventHandler>();

        var serviceProvider = services.BuildServiceProvider();

        var flow = new CreateProductSalesFlow(serviceProvider, new Logger());

        var firstSales = new ProductSale
        {
            CreatedDate = DateTime.UtcNow,
            Product = new Product
            {
                Id = 1,
                Category = new Category
                {
                    Id = 1,
                    Name = "Book",
                    Description = "Book Category"
                }
            },
            PaymentDate = DateTime.UtcNow.AddDays(1),
            Customer = new Customer
            {
                Id = 30034,
                FirstName = "John",
                LastName = "Doe",
                ContactInfo = new ContactInfo
                {
                    ContactType = ContactType.HomePhone,
                    Description = "90-555-55-55" // Telefon gibi bilgileri için ayrı bir veri türü tasarlanabilir mi?
                },
                Address = new Address
                {
                    AddressType = AddressType.HomeAddress,
                    City = "New York",
                    Line_1 = "Kuzey Manhatton Bulvarı, No 10 ",
                    PostalCode = "USA-111",
                    Town = "New York",
                    Street = "Smart Casual Street"
                }
            }
        };

        await flow.SaveAsync(firstSales);
    }
}