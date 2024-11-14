using Microsoft.AspNetCore.Mvc;
using ProductManagementManager.Models.Services.Product.Dtos;
using ProductManagementManager.Models.Services.Product.Services;

namespace ProductManagementManager.Controllers
{
    public class ProductsController(IProductsService productsService) : CustomControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await productsService.Get();
            return CreateObjectResult(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Index(int id)
        {
            var result = await productsService.Get(id);
            return CreateObjectResult(result);
        }
        [HttpPost]
        public async Task<IActionResult> Create(AddRequest request)
        {
            var result = await productsService.Create(request);
            return CreateObjectResult(result);
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateRequest request)
        {
            var result = await productsService.Update(request);
            return CreateObjectResult(result);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await productsService.Delete(id);
            return CreateObjectResult(result);
        }

    }
}
