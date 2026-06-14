using WishList.Application.Interfaces;
using WishList.Domain.Entities;

namespace WishList.Application.Services
{
    public class GetUserWishListsService : IGetUserWishListsService
    {
        private readonly IWishListRepository _wishListRepo;

        public GetUserWishListsService(IWishListRepository wishListRepo)
        {
            _wishListRepo = wishListRepo;
        }

        public async Task<IReadOnlyList<UserWishList>> GetAsync(Guid userId)
        {
            return await _wishListRepo.GetByUserIdAsync(userId);
        }
    }
}
