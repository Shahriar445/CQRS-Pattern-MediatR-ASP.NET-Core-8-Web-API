namespace CQRS.Domain;

public class Product
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Description {get;set;}
    public decimal? Price { get; set; }



        //ParameterLess constructor for ef core 
        private Product() { }
    public Product(string name,string description, decimal price)
    {
        Id =Guid.NewGuid();
        Name =name;
        Description =description;   
        Price =price;
    }

}

