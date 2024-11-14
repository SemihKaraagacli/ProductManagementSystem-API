namespace ProductManagementManager.Models.Services.User.Dtos
{
    public record UpdateUserRequest(Guid UserId, string UserName, string Email);
}
