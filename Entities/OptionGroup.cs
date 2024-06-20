namespace Ef_Cache.Entities;

public class OptionGroup : BaseEntity
{
    public string Name { get; set; }
    public int Min { get; set; }
    public int Max { get; set; }

    public List<Option> Options { get; set; }
}