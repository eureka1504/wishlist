using Microsoft.AspNetCore.Mvc;

namespace WishList.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet("ping")]
        public IActionResult Ping()
        {
            return Ok("PRODCUT CONTROLLER RESPONSE");
        }
    }
}
