using Microsoft.AspNetCore.Mvc;

namespace CSharpTemplate.Api.HealthCheck;

[ApiController]
[Route("health")]
public class HealthCheckController : ControllerBase
{
    [HttpGet]
    public ActionResult<HealthCheckResult> GetHealth()
    {
        try
        {
            bool isSystemHealthy = true;

            if(!isSystemHealthy)
            {
                var unhealthy = HealthCheckResult.Unhealthy("System is not healthy");
                return StatusCode(503, unhealthy);
            }

            var healthy = HealthCheckResult.Healthy("System is healthy");
            return Ok(healthy);
        }
        catch (Exception ex)
        {
            var error = HealthCheckResult.Unhealthy($"Health check failed: {ex.Message}");
            return StatusCode(503, error);
        }
    }
}