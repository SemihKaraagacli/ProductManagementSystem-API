namespace ProductManagementManager.Models.Products.Dtos
{
    public record UpdateRequest(int Id, string Name, string Explain, decimal Price, int Stock);
}
