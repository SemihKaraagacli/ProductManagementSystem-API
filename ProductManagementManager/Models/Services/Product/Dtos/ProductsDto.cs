namespace ProductManagementManager.Models.Services.Product.Dtos
{
    public record ProductsDto(int Id, string Name, string Explain, decimal Price, int Stock);
}
