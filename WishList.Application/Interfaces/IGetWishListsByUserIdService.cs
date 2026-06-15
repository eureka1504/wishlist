using WishList.Domain.Entities;

namespace WishList.Application.Interfaces
{
    public interface IGetWishListsByUserIdService
    {
        Task<IReadOnlyList<UserWishList>> GetByUserIdAsync(Guid userId);
    }
}
