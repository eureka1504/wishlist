using WishList.Application.Interfaces;
using WishList.Domain.Entities;

namespace WishList.Application.Services
{
    public class GetWishListByIdService : IGetWishListByIdService
    {
        private readonly IWishListRepository _wishListRepo;

        public GetWishListByIdService(IWishListRepository wishListRepo)
        {
            _wishListRepo = wishListRepo;
        }

        public async Task<UserWishList?> GetByIdAsync(Guid id)
        {
            return await _wishListRepo.GetByIdAsync(id);
        }
    }
}
