FROM mcr.microsoft.com/dotnet/core/sdk:3.1

ENV DOTNET_USE_POLLING_FILE_WATCHER 1

WORKDIR /app
COPY . .
ENV ASPNETCORE_URLS http://+:3000
EXPOSE 3000
ENTRYPOINT dotnet watch --project EksiCodeBackend.WebAPI/EksiCodeBackend.WebAPI.csproj run --urls=http://+:3000