using WishList.Application.DTOs;
using WishList.Application.Interfaces;

namespace WishList.Application.Services
{
    public class GetWishListsByUserIdService : IGetWishListsByUserIdService
    {
        private readonly IWishListRepository _wishListRepo;

        public GetWishListsByUserIdService(IWishListRepository wishListRepo)
        {
            _wishListRepo = wishListRepo;
        }

        public async Task<IReadOnlyList<WishListResponse>> GetByUserIdAsync(Guid userId)
        {
            return await _wishListRepo.GetByUserIdAsync(userId);
        }
    }
}
