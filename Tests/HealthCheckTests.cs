using Microsoft.AspNetCore.Mvc;
using CSharpTemplate.Api.HealthCheck;
using Xunit;

namespace CSharpTemplate.Api.Tests;

public class HealthCheckTests
{
    [Fact]
    public void GetHealth_ReturnsHealthy()
    {
        // Arrange
        var controller = new HealthCheckController();

        // Action
        var result = controller.GetHealth();

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result.Result);
        var healthCheck = Assert.IsType<HealthCheckResult>(okResult.Value);
        Assert.True(healthCheck.IsHealthy);
        Assert.Equal("Healthy", healthCheck.Status);
    }
}