using WishList.Domain.Enums;

namespace WishList.Domain.Entities
{
    public class Budget
    {
        public Guid Id { get; private set; }

        public Guid UserId { get; private set; }

        public string Name { get; private set; } = string.Empty;

        public decimal Amount { get; private set; }

        public BudgetType Type { get; private set; }

        public DateTime CreatedAtUtc { get; private set; }

        private Budget() {}

        public Budget(
            Guid userId,
            string name,
            decimal amount,
            BudgetType type
        ) 
        {
            Id = Guid.NewGuid();
            UserId = userId;
            Name = name;
            Amount = amount;
            Type = type;
            CreatedAtUtc = DateTime.UtcNow;
        }

        public void UpdateAmount(decimal amount)
        {
            Amount = amount;
        }
    }
}
