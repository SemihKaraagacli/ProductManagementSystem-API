using Microsoft.AspNetCore.Mvc;
using ProductManagementManager.Models.Services.Role;
using ProductManagementManager.Models.Services.Role.Dtos;

namespace ProductManagementManager.Controllers
{
    public class RolesController(RoleService roleService) : CustomControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create(string roleName)
        {
            var result = await roleService.Create(roleName);
            return CreateObjectResult(result);
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await roleService.Get();
            return CreateObjectResult(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await roleService.Get(id);
            return CreateObjectResult(result);
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateRoleRequest updateRoleRequest)
        {
            var result = await roleService.Update(updateRoleRequest);
            return CreateObjectResult(result);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await roleService.Delete(id);
            return CreateObjectResult(result);
        }
        [HttpPost("AddRoleToUser")]
        public async Task<IActionResult> AddRoleToUser(Guid userId, string roleName)
        {
            var result = await roleService.AddRoleToUser(userId, roleName);
            return CreateObjectResult(result);
        }
        [HttpDelete("RemoveRoleToUser")]
        public async Task<IActionResult> RemoveRoleToUser(Guid userId, string roleName)
        {
            var result = await roleService.RemoveRoleToUser(userId, roleName);
            return CreateObjectResult(result);
        }
    }
}
