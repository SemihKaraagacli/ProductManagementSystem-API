using Microsoft.AspNetCore.Mvc;
using ProductManagementManager.Models.Products.Dtos;
using ProductManagementManager.Models.Products.Entites;
using ProductManagementManager.Models.Products.Services;

namespace ProductManagementManager.Controllers
{
    public class ProductsController(IProductsService productsService) : CustomControllerBase
    {
        [HttpGet]
        public IActionResult Index([FromServices] IProductsService service)
        {
            var result = service.Get();
            return CreateObjectResult(result);
        }
        [HttpGet("{id}")]
        public IActionResult Index([FromRoute] int id)
        {
            var result = productsService.Get(id);
            return CreateObjectResult(result);
        }
        [HttpPost]
        public IActionResult Create([FromBody] AddRequest request)
        {
            var result = productsService.Create(request);
            return CreateObjectResult(result);
        }
        [HttpPut]
        public IActionResult Update(UpdateRequest request)
        {
            var result = productsService.Update(request);
            return CreateObjectResult(result);
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var result = productsService.Delete(id);
            return CreateObjectResult(result);
        }
        [HttpGet("EnterMessage")]
        public IActionResult EnterMessage([FromKeyedServices("Enter")] IFromKeyExample fromKey)
        {
            var result = fromKey.Message();
            return Ok(result);
        }
        [HttpGet("ExitMessage")]
        public IActionResult ExitMessage([FromKeyedServices("Exit")] IFromKeyExample fromKey)
        {
            var result = fromKey.Message();
            return Ok(result);
        }
        [HttpGet("HeaderMessage")]
        public IActionResult HeaderMessage([FromHeader(Name = "X-Header")] string header)
        {
            return Ok($"X-Header bilgisi = {header}");
        }
        [HttpGet("query")]
        public IActionResult query([FromQuery] string page)
        {
            Fromquery query = new Fromquery();
            var queryMessage = query.example1(page);
            return Ok(queryMessage);
        }

    }
}
