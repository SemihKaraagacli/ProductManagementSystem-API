namespace Membership.API.Models.Repositories.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public decimal Price { get; set; }

        public Guid UserId { get; set; }
        public AppUser User { get; set; } = default!;
    }
}
