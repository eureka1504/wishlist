using Microsoft.EntityFrameworkCore;
using WishList.Application.DTOs;
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

        public async Task<BudgetResponse?> GetByIdAsync(Guid id)
        {
            return await _dbContext.Budgets
                .Where(budget => budget.Id == id)
                .Select(budget => new BudgetResponse() 
                { 
                    Name = budget.Name,
                    Amount = budget.Amount,
                    Type = budget.Type,
                    UserEmail = budget.User.Email,
                })
                .FirstOrDefaultAsync();
        }

        public async Task<IReadOnlyList<BudgetResponse>> GetByUserIdAsync(Guid userId)
        {
            return await _dbContext.Budgets
                .Where(budget => budget.UserId == userId)
                .Select(budget => new BudgetResponse()
                {
                    Name = budget.Name,
                    Amount = budget.Amount,
                    Type = budget.Type,
                    UserEmail = budget.User.Email,
                })
                .ToListAsync();
        }

        public async Task AddAsync(Budget budget)
        {
            await _dbContext.AddAsync(budget);
        }
    }
}
