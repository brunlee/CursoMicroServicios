public class Pizza
{
    public int Id {get;set;}
    public string Name { get; set; } = string.Empty;
    public string Description {get;set;} = string.Empty;
    public string Url {get;set;} = string.Empty;
    public decimal Price
    { 
        get  
    }
    public List<Ingrediente> Ingredientes { get; set; } = new List<Ingrediente>();
}