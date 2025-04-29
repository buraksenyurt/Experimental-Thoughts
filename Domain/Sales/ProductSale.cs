using Core.Attributes;

namespace Domain.Sales;

[AfterSave]
public class ProductSale
    : IIDomainObject
{
    public Guid TraceId => Guid.NewGuid();
}
