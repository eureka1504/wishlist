namespace WishList.Application.Interfaces
{
    public interface ICreateWishListService
    {
        Task<Guid> CreateAsync(Guid userId, string name);
    }
}
