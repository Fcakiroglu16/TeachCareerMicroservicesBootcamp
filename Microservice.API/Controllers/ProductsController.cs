using Microservice.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Microservice.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController(AppDbContext context) : ControllerBase
    {
        // return product list from appDbContext
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(context.Products.ToList());
        }
    }
}