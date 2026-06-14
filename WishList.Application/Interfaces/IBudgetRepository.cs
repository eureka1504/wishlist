using WishList.Domain.Entities;

namespace WishList.Application.Interfaces
{
    public interface IBudgetRepository
    {
        Task<Budget?> GetByIdAsync(Guid id);
        Task<IReadOnlyList<Budget>> GetByUserIdAsync(Guid userId);
        Task AddAsync(Budget budget);
    }
}
