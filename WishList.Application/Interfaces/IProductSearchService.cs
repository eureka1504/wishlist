using WishList.Application.DTOs;

namespace WishList.Application.Interfaces
{
    public interface IProductSearchService
    {
        Task<IReadOnlyList<ProductResult>> SearchAsync(string query);
    }
}
