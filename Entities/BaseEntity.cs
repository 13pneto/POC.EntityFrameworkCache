namespace Ef_Cache.Entities;

public abstract class BaseEntity
{
    public int Id { get; private set; }
    public DateTime CreatedAt { get; set; }
    
    public string Param1 { get; set; }
    public string Param2 { get; set; }
    public string Param3 { get; set; }
    public string Param4 { get; set; }
    public string Param5 { get; set; }
    public string Param6 { get; set; }
    public string Param7 { get; set; }
    public string Param8 { get; set; }
    public string Param9 { get; set; }
    public string Param10 { get; set; }
    public string Param11 { get; set; }
    public string Param12 { get; set; }
    public string Param13 { get; set; }
    public string Param14 { get; set; }
    public string Param15 { get; set; }
    public string Param16 { get; set; }
    public string Param17 { get; set; }
    public string Param18 { get; set; }
    public string Param19 { get; set; }
    public string Param20 { get; set; }

    public BaseEntity()
    {
        CreatedAt = DateTime.Now;
    }
    
}