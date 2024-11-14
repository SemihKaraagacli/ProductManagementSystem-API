namespace ProductManagementManager.Models.Services.Product.Dtos
{
    public record AddRequest(string? Name, string? Explain, decimal Price, int Stock);
}
