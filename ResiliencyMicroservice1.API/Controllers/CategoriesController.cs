using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResiliencyMicroservice1.API.Services;

namespace ResiliencyMicroservice1.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController(Microservice2Service service) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await service.GetProducts());
        }
    }
}