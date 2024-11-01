namespace ProductManagementManager.Models.Products.Dtos
{
    public record ProductsDto(int Id, string Name, string Explain, decimal Price, int Stock);
}
