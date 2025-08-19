using Microsoft.AspNetCore.Mvc;
using Services;

namespace ECommerceApplication.Controllers
{
    [ApiController]
    [Route("Products")]
    public class PartnerController : Controller
    {
        readonly IPartnerService _services;
        readonly ILogger<PartnerController> _logger;
        public PartnerController(IPartnerService services, ILogger<PartnerController> logger)
        {
            _services = services;
            _logger = logger;
        }
        [HttpGet]
        public async Task<IActionResult> GetProducts([FromQuery] int limit)
        {
            try
            {
              var result = await _services.GetProductsAsync(limit);


                return Ok(result);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex);
            }
        }
    }
}
