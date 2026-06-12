using Microsoft.AspNetCore.Mvc;

namespace WishList.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WishListController : ControllerBase
    {
        [HttpGet("ping")]
        public IActionResult Ping()
        {
            return Ok("WISH LIST CONTROLLER RESPONSE");
        }
    }
}
