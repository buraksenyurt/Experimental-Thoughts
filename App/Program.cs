﻿using App;
using App.Workflows;
using Core;
using Domain.Common;
using Domain.Sales;
using Microsoft.Extensions.DependencyInjection;
using Shared.Contracts;
using Shared.Events;

internal class Program
{
    private static async Task Main()
    {
        var services = new ServiceCollection();

        services.AddSingleton<EventDispatcher>();
        services.AddTransient<ILogger, Logger>();
        services.AddTransient(typeof(IEventHandler<BeforeSaveEvent<ProductSale>>), typeof(BeforeSaveEventHandler<ProductSale>));
        services.AddTransient(typeof(IEventHandler<AfterSaveEvent<ProductSale>>), typeof(AfterSaveEventHandler<ProductSale>));

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
                },
                Name = "Programming with Rust",
                Price = new ListPrice
                {
                    Value = 34.50m
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