
using Microsoft.EntityFrameworkCore;
using posexampleapi.Data.Entities;

namespace posexampleapi.Data;

public class PosDataContext : DbContext
{

    public PosDataContext(DbContextOptions<PosDataContext> options) : base(options)
    {

    }

    public DbSet<ProductsEntity> Products { get; set; }

}