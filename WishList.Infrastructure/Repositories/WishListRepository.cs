using Microsoft.EntityFrameworkCore;
using WishList.Application.DTOs;
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

        public async Task<WishListResponse?> GetByIdAsync(Guid id)
        {
            return await _dbContext.UserWishLists
                .Where(wishList => wishList.Id == id)
                .Select(wishList => new WishListResponse()
                { 
                    Name = wishList.Name,
                    UserEmail = wishList.User.Email,
                    Items = wishList.Items.Select(item => new WishListItemResponse()
                    { 
                        ProductName = item.ProductName,
                        ProductPrice = item.Price,
                    }).ToList(),
                })
                .FirstOrDefaultAsync();
        }

        public async Task<IReadOnlyList<WishListResponse>> GetByUserIdAsync(Guid userId)
        {
            return await _dbContext.UserWishLists
                .Where(wishList => wishList.UserId == userId)
                .Select(wishList => new WishListResponse()
                {
                    Name = wishList.Name,
                    UserEmail = wishList.User.Email,
                    Items = wishList.Items.Select(item => new WishListItemResponse()
                    {
                        ProductName = item.ProductName,
                        ProductPrice = item.Price,
                    }).ToList(),
                })
                .ToListAsync();
        }

        public async Task AddAsync(UserWishList wishList)
        {
            await _dbContext.AddAsync(wishList);
        }
    }
}
