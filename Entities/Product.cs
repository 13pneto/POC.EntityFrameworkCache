namespace Ef_Cache.Entities;

public class Product : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public List<OptionGroup> OptionGroups { get; set; }
}