namespace ProductManagementManager.Models.Products.Dtos
{
    public record AddRequest(string Name, string Explain, decimal Price, int Stock);
}
