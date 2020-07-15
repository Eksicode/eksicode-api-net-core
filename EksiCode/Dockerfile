FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["EksiCode/EksiCode.Api/EksiCode.Api.csproj", ""]
RUN dotnet restore "./EksiCode.Api.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "EksiCode/EksiCode.Api/EksiCode.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EksiCode/EksiCode.Api/EksiCode.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_URLS http://+:3000
EXPOSE 3000
ENTRYPOINT ["dotnet", "EksiCode.Api.dll"]