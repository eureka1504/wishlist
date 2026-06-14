using Microsoft.EntityFrameworkCore;
using WishList.Domain.Entities;

namespace WishList.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users => Set<User>();
        public DbSet<UserWishList> UserWishLists => Set<UserWishList>();
        public DbSet<WishListItem> WishListItems => Set<WishListItem>();
        public DbSet<Budget> Budgets => Set<Budget>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<UserWishList>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.HasOne(e => e.User)
                    .WithMany(e => e.WishLists)
                    .HasForeignKey(e => e.UserId);
            });

            modelBuilder.Entity<WishListItem>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Price)
                    .HasPrecision(18, 2);

                entity.HasOne(e => e.WishList)
                    .WithMany(e => e.Items)
                    .HasForeignKey(e => e.WishListId);
            }
            );

            modelBuilder.Entity<Budget>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Amount)
                    .HasPrecision(18, 2);

                entity.HasOne(e => e.User)
                    .WithMany(e => e.Budgets)
                    .HasForeignKey(e => e.UserId);
            });
        }
    }
}
