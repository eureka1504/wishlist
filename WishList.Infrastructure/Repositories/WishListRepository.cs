using Microsoft.EntityFrameworkCore;
using WishList.Application.Interfaces;
using WishList.Domain.Entities;
using WishList.Infrastructure.Persistence;

namespace WishList.Infrastructure.Repositories
{
    public class WishListRepository : IWishListRepository
    {
        private readonly AppDbContext _dbContext;

        public WishListRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<UserWishList?> GetByIdAsync(Guid id)
        {
            return await _dbContext.UserWishLists.FirstOrDefaultAsync(wishList => wishList.Id == id);
        }

        public async Task<IReadOnlyList<UserWishList>> GetByUserIdAsync(Guid userId)
        {
            return await _dbContext.UserWishLists
                .Where(wishList => wishList.UserId == userId)
                .ToListAsync();
        }

        public async Task AddAsync(UserWishList wishList)
        {
            await _dbContext.AddAsync(wishList);
        }
    }
}
