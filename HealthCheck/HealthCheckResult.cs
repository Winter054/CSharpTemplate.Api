namespace CSharpTemplate.Api.HealthCheck;

public class HealthCheckResult
{
    public string Status { get; }
    public DateTime Timestamp { get; }
    public string? Message { get; }
    public bool IsHealthy { get; }
    
    private HealthCheckResult(string status, bool isHealthy, string? message = null)
    {
        Status = status;
        IsHealthy = isHealthy;
        Message = message;
        Timestamp = DateTime.UtcNow;
    }
    
    public static HealthCheckResult Healthy(string? message = null) => 
        new HealthCheckResult("Healthy", true, message);
    
    public static HealthCheckResult Unhealthy(string? message = null) => 
        new HealthCheckResult("Unhealthy", false, message);
}