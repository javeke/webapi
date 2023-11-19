using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;
using webapi.Dto;

namespace webapi.Controllers
{
    [ApiController]
    [Route("/api/notification")]
    public class NotificationController : ControllerBase
    {

        private readonly ILogger<NotificationController> _logger;

        public NotificationController(ILogger<NotificationController> logger)
        {
            _logger = logger;
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            _logger.LogInformation("Transaction Received");
            return Ok("Transaction Received");
        }

        [HttpPost("")]
        public IActionResult Post([FromBody] NotificationRequest request)
        {
            _logger.LogInformation($"Request Processed: {request}");
            return Ok("Request Processed");
        }
    }
}