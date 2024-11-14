using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProductManagementManager.Models.Repositories.User;
using ProductManagementManager.Models.Services.User.Dtos;
using System.Net;

namespace ProductManagementManager.Models.Services.User
{
    public class UserService(UserManager<AppUser> userManager)
    {
        public async Task<ServiceResult<List<UserDto>>> GetUser()
        {
            var users = await userManager.Users.Select(x => new UserDto(x.Id, x.UserName, x.Email)).ToListAsync();
            return ServiceResult<List<UserDto>>.Success(users, HttpStatusCode.OK);
        }
        public async Task<ServiceResult<UserDto>> GetUser(Guid id)
        {
            var user = await userManager.FindByIdAsync(id.ToString());
            if (user is null)
            {
                return ServiceResult<UserDto>.Fail("Not Found Product", HttpStatusCode.NotFound);
            }
            var userDto = new UserDto(user.Id, user.UserName, user.Email);

            return ServiceResult<UserDto>.Success(userDto, HttpStatusCode.OK);
        }
        public async Task<ServiceResult<Guid>> Add(AddUserRequest addUserRequest)
        {
            var hasUser = await userManager.FindByEmailAsync(addUserRequest.Email);
            if (hasUser != null)
            {
                return ServiceResult<Guid>.Fail("Already user exists", HttpStatusCode.BadRequest);
            }
            var newUser = new AppUser
            {
                Email = addUserRequest.Email,
                UserName = addUserRequest.UserName,
            };
            var result = await userManager.CreateAsync(newUser, addUserRequest.Password);
            if (!result.Succeeded)
            {
                var errorList = result.Errors.Select(x => x.Description).ToList();
                return ServiceResult<Guid>.Fail(errorList, HttpStatusCode.BadRequest);
            }
            return ServiceResult<Guid>.Success(newUser.Id, HttpStatusCode.OK);
        }
        public async Task<ServiceResult> Update(UpdateUserRequest updateUserRequest)
        {
            var hasUser = await userManager.FindByIdAsync(updateUserRequest.UserId.ToString());
            if (hasUser != null)
            {
                return ServiceResult.Fail("Not found user", HttpStatusCode.NotFound);
            }
            hasUser.UserName = updateUserRequest.UserName;
            hasUser.Email = updateUserRequest.Email;
            var result = await userManager.UpdateAsync(hasUser);
            if (!result.Succeeded)
            {
                var errorList = result.Errors.Select(x => x.Description).ToList();
                return ServiceResult.Fail(errorList, HttpStatusCode.BadRequest);
            }
            return ServiceResult.Success(HttpStatusCode.OK);
        }
        public async Task<ServiceResult> Delete(Guid id)
        {
            var hasUser = await userManager.FindByIdAsync(id.ToString());
            if (hasUser == null)
            {
                return ServiceResult.Fail("Not found user", HttpStatusCode.NotFound);
            }
            var result = await userManager.DeleteAsync(hasUser);
            if (!result.Succeeded)
            {
                var errorList = result.Errors.Select(x => x.Description).ToList();
                return ServiceResult.Fail(errorList, HttpStatusCode.BadRequest);
            }
            return ServiceResult.Success(HttpStatusCode.OK);
        }
    }
}
