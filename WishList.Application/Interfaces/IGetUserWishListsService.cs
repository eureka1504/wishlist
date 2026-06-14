using WishList.Domain.Entities;

namespace WishList.Application.Interfaces
{
    public interface IGetUserWishListsService
    {
        Task<IReadOnlyList<UserWishList>> GetAsync(Guid userId);
    }
}
