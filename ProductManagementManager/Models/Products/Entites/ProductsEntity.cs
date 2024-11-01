namespace ProductManagementManager.Models.Products.Entites
{
    public class ProductsEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Explain { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
