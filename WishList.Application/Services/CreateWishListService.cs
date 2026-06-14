using WishList.Application.Interfaces;
using WishList.Domain.Entities;

namespace WishList.Application.Services
{
    public class CreateWishListService : ICreateWishListService
    {
        private readonly IWishListRepository _wishListRepo;
        private readonly IUnitOfWork _unitOfWork;

        public CreateWishListService(
            IWishListRepository wishListRepo,
            IUnitOfWork unitOfWork
        )
        {
            _wishListRepo = wishListRepo;
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> CreateAsync(Guid userId, string name)
        {
            var wishList = new UserWishList(userId, name);

            await _wishListRepo.AddAsync(wishList);
            await _unitOfWork.SaveChangesAsync();

            return wishList.Id;
        }
    }
}
