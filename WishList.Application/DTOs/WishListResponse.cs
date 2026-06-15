namespace WishList.Application.DTOs
{
    public record WishListResponse
    {
        public string Name { get; init; } = string.Empty;
        public string UserEmail { get; init; } = string.Empty;
        public IReadOnlyList<WishListItemResponse> Items { get; init; } = new List<WishListItemResponse>();
    }
}
