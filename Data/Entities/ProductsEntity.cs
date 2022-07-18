namespace posexampleapi.Data.Entities;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class ProductsEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProductId { get; set; }

    [MaxLength(50)]
    public string? Name { get; set; }

    [MaxLength(100)]
    public string? Description { get; set; }

    [MaxLength(100)]
    public string? ImageUrl { get; set; }

    [Range(0, 9999999999999999.99)]
    public decimal? BasePrice { get; set; }

    [Range(0, 9999999999999999.99)]
    public decimal? Price { get; set; }

    public Int16? Quantity { get; set; }

}