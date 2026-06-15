namespace WishList.Api.Models.WishLists
{
    public class CreateWishListRequest
    {
        public Guid UserId { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
