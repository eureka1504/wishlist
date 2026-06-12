namespace WishList.Domain.Entities
{
    public class UserWishList
    {
        public Guid Id { get; private set; }

        public Guid UserId { get; private set; }

        public string Name { get; private set; } = string.Empty;

        public ICollection<WishListItem> Items { get; private set; } = new List<WishListItem>();

        public DateTime CreatedAtUtc { get; private set; }

        private UserWishList() { }

        public UserWishList(
            Guid userId, string name
        )
        {
            Id = Guid.NewGuid();
            UserId = userId;
            Name = name;
            CreatedAtUtc = DateTime.UtcNow;
        }

        public void AddItem(WishListItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(Guid itemId)
        {
            var item = Items.FirstOrDefault(item => item.Id == itemId);

            if (item == null)
            {
                return;
            }

            Items.Remove(item);
        }

        public decimal GetTotalCost()
        {
            return Items.Sum(item => item.Price);
        }
    }
}
