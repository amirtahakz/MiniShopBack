using Microsoft.AspNetCore.Mvc;
using Ui.Api.Models;
using Ui.Core.Repositories;
using Ui.Data.Entities;

namespace Ui.Api.Controllers
{
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [Route("GetProducts")]
        public async Task<IActionResult> GetProducts(string? name)
        {
            return Ok(_productService.GetByName(name));
        }

        [HttpPost]
        [Route("AddProduct")]
        public async Task<IActionResult> AddProduct(ProductVm model)
        {
            await _productService.AddOne(new Product
            {
                Name = model.Name,
                ImageProduct = model.ImageProduct,
                NumbersOfProduct = model.NumbersOfProduct,
                Price = model.Price,
                PriceOffer = model.PriceOffer,
            });
            return Ok();
        }

        [HttpGet]
        [Route("GetProductById")]
        public async Task<IActionResult> GetProductById(Guid id)
        {
            return Ok(await _productService.GetById(id));
        }

    }
}
