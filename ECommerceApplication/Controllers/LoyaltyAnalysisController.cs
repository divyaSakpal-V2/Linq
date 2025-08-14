using Microsoft.AspNetCore.Mvc;
using Services;

namespace ECommerceApplication.Controllers
{
    [ApiController]
    [Route("Customers")]
    public class LoyaltyAnalysisController : Controller
    {
        readonly ILogger<LoyaltyAnalysisController> _logger;
        readonly ILoyaltyService _service;
        public LoyaltyAnalysisController(ILoyaltyService service, ILogger<LoyaltyAnalysisController> logger)
        {
            _logger = logger;
            _service = service;

        }
        [HttpGet("loyalty")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _service.Get();
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }

        }
    }
}
