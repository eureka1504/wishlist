using Microsoft.AspNetCore.Mvc;

namespace WishList.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BudgetController : ControllerBase
    {
        [HttpGet("ping")]
        public IActionResult Ping()
        {
            return Ok("BUDGET CONTROLLER RESPONSE");
        }
    }
}
