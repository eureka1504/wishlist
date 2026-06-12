using WishList.Domain.Entities;

namespace WishList.Application.Interfaces
{
    public interface IWishListRepository
    {
        Task<UserWishList?> GetByIdAsync(Guid id);
        Task<IReadOnlyList<UserWishList>> GetByUserIdAsync(Guid userId);
        Task AddAsync(UserWishList wishList);
        Task RemoveAsync(UserWishList wishList);
        Task SaveChangesAsync();
    }
}
