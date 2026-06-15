using WishList.Application.DTOs;

namespace WishList.Application.Interfaces
{
    public interface IGetWishListsByUserIdService
    {
        Task<IReadOnlyList<WishListResponse>> GetByUserIdAsync(Guid userId);
    }
}
