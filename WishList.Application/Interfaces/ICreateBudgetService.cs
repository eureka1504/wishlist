using WishList.Domain.Enums;

namespace WishList.Application.Interfaces
{
    public interface ICreateBudgetService
    {
        Task<Guid> CreateAsync(Guid userId, string name, decimal amount, BudgetType type);
    }
}
