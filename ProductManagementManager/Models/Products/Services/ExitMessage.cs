namespace ProductManagementManager.Models.Products.Services
{
    public class ExitMessage : IFromKeyExample
    {
        public string Message()
        {
            var message = "Güle Güle";
            return message;
        }
    }
}
