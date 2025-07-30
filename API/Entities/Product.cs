namespace API.Entities;

public class Product
{
    public Guid Id { get; set; } 
    public required string Name { get; set; } 
    public string Description { get; set; }
    public long Price { get; set; }
    public required string PictureUrl { get; set; }
    public string Type { get; set; }
    public required string Brand { get; set; }
    public int QuantityInStock { get; set; }
}