using WishList.Domain.Enums;

namespace WishList.Application.DTOs
{
    public record BudgetResponse
    {
        public string Name { get; init; } = string.Empty;
        public decimal Amount { get; init; }
        public BudgetType Type { get; init; }
        public string UserEmail { get; init; } = string.Empty;
    }
}
