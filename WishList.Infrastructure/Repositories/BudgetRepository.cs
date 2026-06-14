using Microsoft.EntityFrameworkCore;
using WishList.Application.Interfaces;
using WishList.Domain.Entities;
using WishList.Infrastructure.Persistence;

namespace WishList.Infrastructure.Repositories
{
    public class BudgetRepository : IBudgetRepository
    {
        private readonly AppDbContext _dbContext;

        public BudgetRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Budget?> GetByIdAsync(Guid id)
        {
            return await _dbContext.Budgets.FirstOrDefaultAsync(budget => budget.Id == id);
        }

        public async Task<IReadOnlyList<Budget>> GetByUserIdAsync(Guid userId)
        {
            return await _dbContext.Budgets.Where(budget => budget.UserId == userId).ToListAsync();
        }

        public async Task AddAsync(Budget budget)
        {
            await _dbContext.AddAsync(budget);
        }
    }
}
