using Domain.Common;
using Domain.Contracts;

namespace Domain.Sales;

public class ProductSale
    : IIDomainObject, IValidatable, ITrackable
{
    public Guid TraceId => Guid.NewGuid();
    public Product Product { get; set; }
    public Customer Customer { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime PaymentDate { get; set; } // PaymentDate diye ayrı bir tür olarak tasarlanabilir

    public void TrackChanges()
    {
        if (Product == null)
        {
            throw new ArgumentNullException(nameof(Product), "Product cannot be null.");
        }
        if (Customer == null)
        {
            throw new ArgumentNullException(nameof(Customer), "Customer cannot be null.");
        }
    }

    public void Validate()
    {
        // Neler yapılabilir?
    }
}
