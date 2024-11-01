
namespace ProductManagementManager.Models.Products.Services
{
    public class EnterMessage : IFromKeyExample
    {
        public string Message()
        {
            var message = "Hoşgeldiniz";
            return message;
        }
    }
}
