namespace API.DTOs;

public class BasketDto
{
    public Guid Id { get; set; }
    public required string BasketId { get; set; }
    public List<BasketItemDto> Items { get; set; } = [];
}