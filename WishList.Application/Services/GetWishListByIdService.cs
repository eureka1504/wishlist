using WishList.Application.DTOs;
using WishList.Application.Interfaces;

namespace WishList.Application.Services
{
    public class GetWishListByIdService : IGetWishListByIdService
    {
        private readonly IWishListRepository _wishListRepo;

        public GetWishListByIdService(IWishListRepository wishListRepo)
        {
            _wishListRepo = wishListRepo;
        }

        public async Task<WishListResponse?> GetByIdAsync(Guid id)
        {
            return await _wishListRepo.GetByIdAsync(id);
        }
    }
}
