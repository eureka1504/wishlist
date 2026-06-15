using WishList.Application.DTOs;

namespace WishList.Application.Interfaces
{
    public interface IGetWishListByIdService
    {
        Task<WishListResponse?> GetByIdAsync(Guid id);
    }
}
