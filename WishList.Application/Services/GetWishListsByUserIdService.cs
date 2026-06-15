using WishList.Application.Interfaces;
using WishList.Domain.Entities;

namespace WishList.Application.Services
{
    public class GetWishListsByUserIdService : IGetWishListsByUserIdService
    {
        private readonly IWishListRepository _wishListRepo;

        public GetWishListsByUserIdService(IWishListRepository wishListRepo)
        {
            _wishListRepo = wishListRepo;
        }

        public async Task<IReadOnlyList<UserWishList>> GetByUserIdAsync(Guid userId)
        {
            return await _wishListRepo.GetByUserIdAsync(userId);
        }
    }
}
