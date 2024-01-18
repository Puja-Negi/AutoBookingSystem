using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace AutoBooking.Api.Controllers
{
    public class ErrorsController : BaseController
    {
        [Route("error")]
        public IActionResult Error()
        {
            Exception? exception = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;
            return Problem(title: exception?.Message, statusCode: 400);
        }
    }
}