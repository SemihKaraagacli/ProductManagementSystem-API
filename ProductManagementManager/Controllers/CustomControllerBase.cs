using Microsoft.AspNetCore.Mvc;
using ProductManagementManager.Models;
using System.Net;

namespace ProductManagementManager.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class CustomControllerBase : ControllerBase
    {
        [NonAction]
        public IActionResult CreateObjectResult<T>(ServiceResult<T> result)
        {
            if (result.IsFail)
            {
                if (result.Status == HttpStatusCode.NotFound)
                {
                    return NotFound();
                }


                return new ObjectResult(result.Errors)
                {
                    StatusCode = (int)result.Status
                };
            }

            return new ObjectResult(result.Data)
            {
                StatusCode = (int)result.Status
            };
        }

        [NonAction]
        public ActionResult CreateObjectResult(ServiceResult result)
        {
            if (result.IsFail)
            {
                if (result.Status == HttpStatusCode.NotFound)
                {
                    return NotFound();
                }


                return new ObjectResult(result.Errors)
                {
                    StatusCode = (int)result.Status
                };
            }

            return NoContent();
        }
    }
}
