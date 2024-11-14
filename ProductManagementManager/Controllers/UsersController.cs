using Microsoft.AspNetCore.Mvc;
using ProductManagementManager.Models.Services.User;
using ProductManagementManager.Models.Services.User.Dtos;

namespace ProductManagementManager.Controllers
{
    public class UsersController(UserService userService) : CustomControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await userService.GetUser();
            return CreateObjectResult(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Index(Guid id)
        {
            var result = await userService.GetUser(id);
            return CreateObjectResult(result);
        }
        [HttpPost]
        public async Task<IActionResult> Create(AddUserRequest request)
        {
            var result = await userService.Add(request);
            return CreateObjectResult(result);
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateUserRequest request)
        {
            var result = await userService.Update(request);
            return CreateObjectResult(result);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await userService.Delete(id);
            return CreateObjectResult(result);
        }
    }
}
