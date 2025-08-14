using Microsoft.AspNetCore.Mvc;
using Services;

namespace ECommerceApplication.Controllers
{
    [ApiController]
    [Route("Products")]
    public class SeasonalSalesAnalysisController : Controller
    {
        readonly ILogger<SeasonalSalesAnalysisController> _logger;
        readonly ISeasonalSalesService _service;

        public SeasonalSalesAnalysisController(ISeasonalSalesService service, ILogger<SeasonalSalesAnalysisController> logger)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet("seasonal-tops")]
        public async Task<IActionResult> Get([FromQuery] int topN)
        {
            try
            {
                var result = _service.Get(topN);
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
