FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
#EXPOSE 80
#EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-alpine AS build
WORKDIR /src
COPY ["EksiCodeBackend/EksiCodeBackend.WebAPI/EksiCodeBackend.WebAPI.csproj", "EksiCodeBackend/EksiCodeBackend.WebAPI/"]
RUN dotnet restore "EksiCodeBackend/EksiCodeBackend.WebAPI/EksiCodeBackend.WebAPI.csproj"
COPY . .
WORKDIR "/src/EksiCodeBackend/EksiCodeBackend.WebAPI"
RUN dotnet build "EksiCodeBackend.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EksiCodeBackend.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_URLS http://+:3000
EXPOSE 3000
ENTRYPOINT ["dotnet", "EksiCodeBackend.WebAPI.dll"]
