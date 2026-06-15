using WishList.Application.DTOs;
using WishList.Application.Interfaces;

namespace WishList.Application.Services
{
    public class GetBudgetByUserIdService : IGetBudgetByUserIdService
    {
        private readonly IBudgetRepository _budgerRepo;

        public GetBudgetByUserIdService(IBudgetRepository budgetRepo)
        { 
            _budgerRepo = budgetRepo;
        }

        public async Task<IReadOnlyList<BudgetResponse>> GetByUserIdAsync(Guid userId)
        {
            return await _budgerRepo.GetByUserIdAsync(userId);
        }
    }
}
