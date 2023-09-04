using Microsoft.AspNetCore.Mvc;

namespace ShopApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        public ProductsController()
        {
            
        }

        [HttpGet]   
        public string[] GetProducts()
        {
            return Products;
        }

        [HttpGet("{id}")]
        public string GetProduct(int id)
        {
            return Products[id];
        }
    }
}
