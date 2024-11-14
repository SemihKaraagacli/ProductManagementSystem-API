using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProductManagementManager.Models.Repositories.User;
using ProductManagementManager.Models.Services.Role.Dtos;
using System.Net;

namespace ProductManagementManager.Models.Services.Role
{
    public class RoleService(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
    {
        public async Task<ServiceResult<Guid>> Create(string role)
        {
            var hasRole = await roleManager.FindByNameAsync(role);
            if (hasRole != null)
            {
                return ServiceResult<Guid>.Fail("Role already exists.", HttpStatusCode.BadRequest);
            }
            var roleName = new AppRole
            {
                Name = role,
            };

            if (hasRole is null)
            {
                var createRole = await roleManager.CreateAsync(roleName);
                if (!createRole.Succeeded)
                {
                    var errorList = createRole.Errors.Select(x => x.Description).ToList();
                    return ServiceResult<Guid>.Fail(errorList, HttpStatusCode.BadRequest);
                }
            }
            return ServiceResult<Guid>.Success(roleName.Id, HttpStatusCode.OK);
        }
        public async Task<ServiceResult> Update(UpdateRoleRequest updateRoleRequest)
        {
            var hasRole = await roleManager.FindByIdAsync(updateRoleRequest.Id.ToString());
            if (hasRole is null)
            {
                return ServiceResult.Fail("Role not found.", HttpStatusCode.NotFound);
            }
            hasRole.Id = updateRoleRequest.Id;
            hasRole.Name = updateRoleRequest.Name;

            var updateRole = await roleManager.UpdateAsync(hasRole);
            if (!updateRole.Succeeded)
            {
                var errorList = updateRole.Errors.Select(x => x.Description).ToList();
                return ServiceResult<Guid>.Fail(errorList, HttpStatusCode.BadRequest);
            }
            return ServiceResult.Success(HttpStatusCode.OK);
        }
        public async Task<ServiceResult> Delete(Guid id)
        {
            var hasRole = await roleManager.FindByIdAsync(id.ToString());
            if (hasRole is null)
            {
                return ServiceResult.Fail("Role not found.", HttpStatusCode.NotFound);
            }
            var deleteRole = await roleManager.DeleteAsync(hasRole);
            if (!deleteRole.Succeeded)
            {
                var errorList = deleteRole.Errors.Select(x => x.Description).ToList();
                return ServiceResult.Fail(errorList, HttpStatusCode.BadRequest);
            }
            return ServiceResult.Success(HttpStatusCode.OK);
        }
        public async Task<ServiceResult<List<RoleDto>>> Get()
        {
            var allRole = await roleManager.Roles.Select(x => new RoleDto(x.Id, x.Name)).ToListAsync();
            return ServiceResult<List<RoleDto>>.Success(allRole, HttpStatusCode.OK);
        }
        public async Task<ServiceResult<RoleDto>> Get(Guid id)
        {
            var hasRole = await roleManager.FindByIdAsync(id.ToString());
            if (hasRole is null)
            {
                return ServiceResult<RoleDto>.Fail("Role not found.", HttpStatusCode.NotFound);
            }
            var selectedRole = new RoleDto(
                hasRole.Id,
                hasRole.Name
                );
            return ServiceResult<RoleDto>.Success(selectedRole, HttpStatusCode.OK);

        }
        public async Task<ServiceResult> AddRoleToUser(Guid userId, string roleName)
        {
            var hasUser = await userManager.FindByIdAsync(userId.ToString());
            if (hasUser is null)
            {
                return ServiceResult.Fail("User not found.", HttpStatusCode.NotFound);
            }
            var hasRole = await roleManager.FindByNameAsync(roleName);
            if (hasRole is null)
            {
                return ServiceResult.Fail("Role not found.", HttpStatusCode.NotFound);
            }
            var addToRole = await userManager.AddToRoleAsync(hasUser, roleName);
            if (!addToRole.Succeeded)
            {
                var errorList = addToRole.Errors.Select(x => x.Description).ToList();
                return ServiceResult<Guid>.Fail(errorList, HttpStatusCode.BadRequest);
            }
            return ServiceResult.Success(HttpStatusCode.OK);
        }
        public async Task<ServiceResult> RemoveRoleToUser(Guid userId, string roleName)
        {
            var hasUser = await userManager.FindByIdAsync(userId.ToString());
            if (hasUser is null)
            {
                return ServiceResult.Fail("User not found.", HttpStatusCode.NotFound);
            }
            var hasRole = await roleManager.FindByNameAsync(roleName);
            if (hasRole is null)
            {
                return ServiceResult.Fail("Role not found.", HttpStatusCode.NotFound);
            }
            var RemoveToRole = await userManager.RemoveFromRoleAsync(hasUser, roleName);
            if (!RemoveToRole.Succeeded)
            {
                var errorList = RemoveToRole.Errors.Select(x => x.Description).ToList();
                return ServiceResult<Guid>.Fail(errorList, HttpStatusCode.BadRequest);
            }
            return ServiceResult.Success(HttpStatusCode.OK);
        }
    }
}

