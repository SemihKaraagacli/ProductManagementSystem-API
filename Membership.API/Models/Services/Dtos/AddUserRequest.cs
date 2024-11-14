namespace Membership.API.Models.Services.Dtos
{
    public record AddUserRequest(string UserName, string Email, string Password, string? City, DateTime? BirthDate);
}
