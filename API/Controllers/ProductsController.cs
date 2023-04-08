using Core.Entities;
using Core.Interface;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
            
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var Products = await _productRepository.GetProductAsync();

            return Ok(Products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Product>>> GetProducts(int id)
        {

            return Ok(await _productRepository.GetProductsByIdAsync(id));
        }


    }
}
