# Deployment Instructions

## Docker Image
- Image name: csharp-template-api
- Port: 8080
- Health check endpoint: /health
- Swagger endpoint: /swagger

## Running the Container
```bash
# Load the image
docker load < csharp-template-api.tar

# Run the container
docker run -d \
  -p 8080:8080 \
  -e ASPNETCORE_URLS="http://+:8080" \
  --name csharp-api \
  csharp-template-api
```

## Health Check
- Endpoint: /health
- Expected response: 200 OK with health status

## Requirements
- Docker runtime
- Port 8080 available