FROM mcr.microsoft.com/dotnet/sdk:9.0-alpine AS build
WORKDIR /src
COPY ["CSharpTemplate.Api.csproj", "./"]
RUN dotnet restore
COPY . .
RUN dotnet publish -c Release -o /app/publish /p:PublishTrimmed=true /p:PublishSingleFile=true /p:DebugType=none /p:DebugSymbols=false

FROM mcr.microsoft.com/dotnet/runtime-deps:9.0-alpine AS final
WORKDIR /app
COPY --from=build /app/publish .
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080
ENTRYPOINT ["./CSharpTemplate.Api"]