using WishList.Domain.Entities;

namespace WishList.Application.Interfaces
{
    public interface IGetWishListByIdService
    {
        Task<UserWishList?> GetByIdAsync(Guid id);
    }
}
