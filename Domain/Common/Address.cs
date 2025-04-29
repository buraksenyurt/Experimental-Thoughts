namespace Domain.Common;

public class Address
{
    public AddressType AddressType { get; set; }
    public string Line_1 { get; set; }
    public string Street { get; set; }
    public string Town { get; set; }
    public string City { get; set; }
    public string PostalCode { get; set; }
    public string Detail { get; set; }
}
