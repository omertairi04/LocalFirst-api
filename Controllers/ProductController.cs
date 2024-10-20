using System.Security.Claims;
using api.Interfaces;
using Local_Alternatives.Data;
using Local_Alternatives.Dtos.Product;
using Local_Alternatives.Mapper;
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
    public async Task<IActionResult> GetProducts()
    {
        try
        {
            if (!ModelState.IsValid) return BadRequest();

            var products = await _productRepository.GetAllProductsAsync();
            return Ok(products);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, "Error creating product" + e.Message);
        }
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetProduct([FromRoute] Guid id)
    {
        try
        {
            if (!ModelState.IsValid) return BadRequest();

            var product = await _productRepository.GetProductByIdAsync(id);
            return Ok(product);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, "Error creating product" + e.Message);
        }
    }

    [HttpPost]
    [Authorize(Roles = "Company")]
    public async Task<IActionResult> CreateProduct([FromBody] CreateProductDto product)
    {
        try
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            // Log claims for debugging
            var claims = User.Claims.ToList();
            foreach (var claim in claims)
            {
                Console.WriteLine($"Claim Type: {claim.Type}, Claim Value: {claim.Value}");
            }

            // Retrieve the user ID from the claims
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userRole = User.FindFirstValue(ClaimTypes.Role);
            Console.WriteLine($"User Role: {userRole}");

            if (userId == null)
            {
                return Unauthorized("Unable to retrieve user ID from the token.");
            }

            // Create a new product from DTO
            var cp = product.ToProductFromCreateDto();
            cp.CompanyId = userId; // Associate the product with the logged-in company

            await _productRepository.CreateProductAsync(cp); // Save the product

            return CreatedAtAction(nameof(GetProduct), new { id = cp.Id }, cp.ToProductDto());
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, "Error creating product: " + e.Message);
        }
    }
    
    [HttpPut("{id}")]
    [Authorize]
    public async Task<IActionResult> UpdateProduct([FromRoute] Guid id, [FromBody] UpdateProductDto product)
    {
        try
        {
            if (!ModelState.IsValid) return BadRequest();

            var prod = await _productRepository.UpdateProductAsync(id, product);
            if (prod == null) return NotFound();

            return Ok(prod.ToProductDto());
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, "Error updating product");
        }
    }

    [HttpDelete("{id}")]
    [Authorize]
    public async Task<IActionResult> DeleteProduct([FromRoute] Guid id)
    {
        try
        {
            if (!ModelState.IsValid) return BadRequest();

            var prod = await _productRepository.DeleteProductAsync(id);
            if (prod == null) return NotFound();

            return NoContent();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return StatusCode(500, "Error creating product" + e.Message);
        }
    }
}