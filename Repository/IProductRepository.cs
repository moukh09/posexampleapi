

namespace posexampleapi.Repository
{
    using posexampleapi.Data.Entities;

    public interface IProductRepository
    {
        Task<List<ProductsEntity>> GetProducts();
    }
}