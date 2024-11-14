namespace Membership.API.Models.Services.Dtos
{
    public record UserDto(Guid UserId, string UserName, string Email, string? City, DateTime? BirthDate);
}
