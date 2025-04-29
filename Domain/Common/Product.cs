namespace Domain.Common;

public class Product
    : BaseEntity
{
    public string Name { get; set; }
    public ListPrice Price { get; set; }
    public Category Category { get; set; }
}
