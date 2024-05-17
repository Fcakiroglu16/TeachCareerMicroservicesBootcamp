using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ResiliencyMicroservice2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            throw new Exception("db hatası");
            return Ok("Microservice 2 - Products");
        }
    }
}