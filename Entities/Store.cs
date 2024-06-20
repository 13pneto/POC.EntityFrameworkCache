namespace Ef_Cache.Entities;

public class Store : BaseEntity
{
    public string Name { get; set; }
    
    public List<Category> Categories { get; set; }
}