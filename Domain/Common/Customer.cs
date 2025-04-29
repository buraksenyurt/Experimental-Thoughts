namespace Domain.Common;

public class Customer
    : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public ContactInfo ContactInfo { get; set; }
    public Address Address { get; set; }
}
