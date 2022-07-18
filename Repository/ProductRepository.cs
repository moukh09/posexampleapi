
namespace posexampleapi.Repository;

using posexampleapi.Data;
using posexampleapi.Data.Entities;

using Microsoft.EntityFrameworkCore;

public class ProductRepository : IProductRepository
{

    private readonly PosDataContext _posDataContext;

    public ProductRepository(PosDataContext posDataContext)
    {
        _posDataContext = posDataContext;
    }

    public async Task<List<ProductsEntity>> GetProducts()
    {
        return await _posDataContext.Products.ToListAsync();
    }

}