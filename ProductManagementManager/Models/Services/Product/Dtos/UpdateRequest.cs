namespace ProductManagementManager.Models.Services.Product.Dtos
{
    public record UpdateRequest(int Id, string? Name, string? Explain, decimal Price, int Stock);
}
