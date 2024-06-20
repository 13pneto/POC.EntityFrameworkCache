namespace Ef_Cache.Entities;

public class Category : BaseEntity
{
    public string Name { get; set; }
    public List<Product> Products { get; set; }
    public List<Store> Stores { get; set; }
}