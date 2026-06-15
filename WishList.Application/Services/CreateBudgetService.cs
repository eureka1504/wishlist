using WishList.Application.Interfaces;
using WishList.Domain.Entities;
using WishList.Domain.Enums;

namespace WishList.Application.Services
{
    public class CreateBudgetService : ICreateBudgetService
    {
        private readonly IBudgetRepository _budgetRepo;
        private readonly IUnitOfWork _unitOfWork;

        public CreateBudgetService(
            IBudgetRepository budgetRepo,
            IUnitOfWork unitOfWork
        )
        {
            _budgetRepo = budgetRepo;
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> CreateAsync(Guid userId, string name, decimal amount, BudgetType type)
        {
            var budget = new Budget(userId, name, amount, type);

            await _budgetRepo.AddAsync(budget);
            await _unitOfWork.SaveChangesAsync();

            return budget.Id;
        }
    }
}
