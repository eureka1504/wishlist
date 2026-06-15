using Microsoft.AspNetCore.Mvc;
using WishList.Api.Models.Budgets;
using WishList.Application.Interfaces;

namespace WishList.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BudgetController : ControllerBase
    {
        private readonly IGetBudgetByIdService _getBudgetByIdService;
        private readonly IGetBudgetByUserIdService _getBudgetByUserIdService;
        private readonly ICreateBudgetService _createBudgetService;

        public BudgetController(
            IGetBudgetByIdService getBudgetByIdService,
            IGetBudgetByUserIdService getBudgetByUserIdService,
            ICreateBudgetService createBudgetService
        )
        {
            _getBudgetByIdService = getBudgetByIdService;
            _getBudgetByUserIdService = getBudgetByUserIdService;
            _createBudgetService = createBudgetService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var budget = await _getBudgetByIdService.GetBudgetByIdAsync(id);

            return Ok(budget);
        }

        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetByUserId(Guid userId)
        { 
            var budgets = await _getBudgetByUserIdService.GetByUserIdAsync(userId);

            return Ok(budgets);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody]CreateBudgetRequest request)
        {
            var budgetId = await _createBudgetService.CreateAsync(request.UserId, request.Name, request.Amount, request.Type);

            return Ok(budgetId);
        }
    }
}
