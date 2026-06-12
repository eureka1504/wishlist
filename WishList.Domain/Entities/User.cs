namespace WishList.Domain.Entities
{
    public class User
    {
        public Guid Id { get; private set; }

        public string Email { get; private set; } = string.Empty;

        public string PasswordHash { get; private set; } = string.Empty;

        public ICollection<UserWishList> WishLists { get; private set; } = new List<UserWishList>();

        public ICollection<Budget> Budgets { get; private set; } = new List<Budget>();

        public DateTime CreatedAtUtc { get; private set; }

        private User() { }

        public User(
            string email,
            string passwordHash
        ) 
        {
            Id = Guid.NewGuid();
            Email = email;
            PasswordHash = passwordHash;
            CreatedAtUtc = DateTime.UtcNow;
        }

        public void AddWishList(UserWishList wishList)
        {
            WishLists.Add(wishList);
        }

        public void AddBudget(Budget budget)
        {
            Budgets.Add(budget);
        }
    }
}
