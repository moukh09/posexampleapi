
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using posexampleapi.Models;
using posexampleapi.Repository;
using System.Text.Json;

namespace posexampleapi.Controller;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public ProductController(IMapper mapper, IProductRepository productRepository)
    {
        _mapper = mapper;
        _productRepository = productRepository;
    }


    [HttpGet]
    public async Task<IActionResult> GetProducts()
    {
        var list = await _productRepository.GetProducts();
        var result = _mapper.Map<List<ProductsDTO>>(list);

        return Ok(JsonSerializer.Serialize(result));
    }

}