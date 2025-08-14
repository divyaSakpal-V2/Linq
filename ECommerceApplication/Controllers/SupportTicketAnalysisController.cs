using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services;

namespace ECommerceApplication.Controllers
{
    [ApiController]
    [Route("Support")]
    public class SupportTicketAnalysisController : Controller
    {
        readonly ISupportTicketService _service;
        readonly ILogger<SupportTicketAnalysisController> _logger;

        public SupportTicketAnalysisController(ISupportTicketService service, ILogger<SupportTicketAnalysisController> logger)
        {

            _service = service;
            _logger = logger;
        }

        [HttpGet("Analyze")]
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
