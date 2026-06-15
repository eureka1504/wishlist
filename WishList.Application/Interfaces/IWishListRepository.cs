using WishList.Application.DTOs;
using WishList.Domain.Entities;

namespace WishList.Application.Interfaces
{
    public interface IWishListRepository
    {
        Task<WishListResponse?> GetByIdAsync(Guid id);
        Task<IReadOnlyList<WishListResponse>> GetByUserIdAsync(Guid userId);
        Task AddAsync(UserWishList wishList);
    }
}
