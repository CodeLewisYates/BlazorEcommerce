using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DataContext _dbContext;
        public ProductController(DataContext context)
        {
            _dbContext = context;
        }
        //get
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var products = await _dbContext.Products.ToListAsync();
            return Ok(products);
        }
    }
}
