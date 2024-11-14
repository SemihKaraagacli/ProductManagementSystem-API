using Microsoft.AspNetCore.Mvc;
using ProductManagementManager.Models.Services;

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
                //if (result.Status == HttpStatusCode.NotFound)
                //{
                //    return NotFound();
                //}

                var problemDetails = new ProblemDetails()
                {
                    Type = "https://tools.ietf.org/html/rfc9110#section-15.6.1",
                    Title = "Bir hata oluştu.",
                    Status = (int)result.Status,
                    Detail = result.Errors.First()
                };

                return new ObjectResult(problemDetails)
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
                //if (result.Status == HttpStatusCode.NotFound)
                //{
                //    return NotFound();
                //}
                var problemDetails = new ProblemDetails()
                {
                    Type = "https://tools.ietf.org/html/rfc9110#section-15.6.1",
                    Title = "Bir hata oluştu.",
                    Status = (int)result.Status,
                    Detail = result.Errors.First()
                };

                return new ObjectResult(problemDetails)
                {
                    StatusCode = (int)result.Status
                };
            }

            return NoContent();
        }
    }
}
