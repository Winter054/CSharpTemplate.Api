# C# API Template

A lightweight .NET API template with health check endpoint and Swagger documentation.

## Features

- Health Check endpoint
- Swagger UI documentation
- Docker support with optimized image size
- Alpine-based container for minimal footprint

## Prerequisites

- .NET 9.0 SDK
- Docker

## Quick Start

### Running Locally

```bash
dotnet restore
dotnet run
```

Access:
- Health Check: http://localhost:8080/health
- Swagger UI: http://localhost:8080/swagger

### Using Docker

Build the image:
```bash
docker build -t csharp-template-api .
```

Run the container:
```bash
docker run -d -p 8080:8080 --name csharp-api csharp-template-api
```

## API Endpoints

- GET /health - Returns API health status
  ```json
  {
    "status": "Healthy",
    "timestamp": "2024-03-08T12:34:56.789Z",
    "message": "API is running normally",
    "isHealthy": true
  }
  ```

## Configuration

Environment variables:
- `ASPNETCORE_URLS` - Default: "http://+:8080"
- `ASPNETCORE_ENVIRONMENT` - Development/Production

## Project Structure

```
CSharpTemplate.Api/
├── HealthCheck/
│   ├── HealthCheckController.cs
│   └── HealthCheckResult.cs
├── Properties/
│   └── launchSettings.json
├── Dockerfile
├── Program.cs
└── appsettings.json
``` 