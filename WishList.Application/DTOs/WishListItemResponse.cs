namespace WishList.Application.DTOs
{
    public record WishListItemResponse
    {
        public string ProductName { get; init; } = string.Empty;
        public decimal ProductPrice { get; init; }
    }
}
