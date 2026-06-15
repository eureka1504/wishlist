using WishList.Domain.Enums;

namespace WishList.Api.Models.Budgets
{
    public class CreateBudgetRequest
    {
        public Guid UserId { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public BudgetType Type { get; set; }
    }
}
