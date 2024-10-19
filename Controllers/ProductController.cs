using api.Interfaces;
using Local_Alternatives.Data;
using Local_Alternatives.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Local_Alternatives.Controllers;

[Route("api/product")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly IProductRepository _productRepository;

    public ProductController(ApplicationDbContext context, IProductRepository productRepository)
    {
        _context = context;
        _productRepository = productRepository;
    }

    [HttpGet]
    [Authorize]
    public async Task<IActionResult> GetProducts()
    {
        if (!ModelState.IsValid) return BadRequest();

        var products = await _productRepository.GetAllProductsAsync();
        return Ok(products);
    }
}