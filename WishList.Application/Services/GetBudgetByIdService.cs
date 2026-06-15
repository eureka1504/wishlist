using WishList.Application.DTOs;
using WishList.Application.Interfaces;

namespace WishList.Application.Services
{
    public class GetBudgetByIdService : IGetBudgetByIdService
    {
        private readonly IBudgetRepository _budgetRepo;

        public GetBudgetByIdService(IBudgetRepository budgetRepo)
        {
            _budgetRepo = budgetRepo;
        }

        public async Task<BudgetResponse?> GetByIdAsync(Guid id)
        {
            return await _budgetRepo.GetByIdAsync(id);
        }
    }
}
