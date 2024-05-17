using Microservice.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;

namespace Microservice.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController(AppDbContext context, IDistributedCache cache) : ControllerBase
    {
        // return product list from appDbContext
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(context.Products.ToList());
        }

        [HttpPost]
        public IActionResult Post()
        {
            cache.SetStringAsync("key1", "value1");

            return Ok();
        }
    }
}