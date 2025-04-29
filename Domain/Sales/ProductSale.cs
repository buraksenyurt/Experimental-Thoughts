using Domain.Common;

namespace Domain.Sales;

public class ProductSale
    : IIDomainObject
{
    public Guid TraceId => Guid.NewGuid();
    public Product Product { get; set; }
    public Customer Customer  { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime PaymentDate { get; set; } // PaymentDate diye ayrı bir tür olarak tasarlanabilir
}
