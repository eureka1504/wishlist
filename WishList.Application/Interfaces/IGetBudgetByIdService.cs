using WishList.Application.DTOs;

namespace WishList.Application.Interfaces
{
    public interface IGetBudgetByIdService
    {
        Task<BudgetResponse?> GetBudgetByIdAsync(Guid id);
    }
}
