namespace Membership.API.Models.Services.Dtos
{
    public record UpdateUserRequest(Guid UserId, string UserName, string Email, string? City, DateTime? BirthDate);
}
