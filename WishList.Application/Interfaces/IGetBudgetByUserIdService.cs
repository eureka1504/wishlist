using WishList.Application.DTOs;

namespace WishList.Application.Interfaces
{
    public interface IGetBudgetByUserIdService
    {
        Task<IReadOnlyList<BudgetResponse>> GetByUserIdAsync(Guid userId);
    }
}
