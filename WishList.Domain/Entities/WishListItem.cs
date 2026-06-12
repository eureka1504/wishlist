namespace WishList.Domain.Entities
{
    public class WishListItem
    {
        public Guid Id { get; private set; }

        public Guid WishListId { get; private set; }

        public string ProductId { get; private set; } = string.Empty;

        public string ProductName { get; private set; } = string.Empty;

        public decimal Price { get; private set; }

        public string ImageUrl { get; private set; } = string.Empty;

        public string ProductUrl { get; private set; } = string.Empty;

        public DateTime CreatedAtUtc { get; private set; }

        private WishListItem() { }

        public WishListItem(
            Guid wishListId,
            string productId,
            string productName,
            decimal price,
            string imageUrl,
            string productUrl
        )
        {
            Id = Guid.NewGuid();
            WishListId = wishListId;
            ProductId = productId;
            ProductName = productName;
            Price = price;
            ImageUrl = imageUrl;
            ProductUrl = productUrl;
            CreatedAtUtc = DateTime.UtcNow;
        }
    }
}
