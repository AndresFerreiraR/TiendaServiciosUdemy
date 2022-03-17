#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CarritoCompras/TiendaServicios.API.CarritoCompras/TiendaServicios.API.CarritoCompras.csproj", "CarritoCompras/TiendaServicios.API.CarritoCompras/"]
RUN dotnet restore "CarritoCompras/TiendaServicios.API.CarritoCompras/TiendaServicios.API.CarritoCompras.csproj"
COPY . .
WORKDIR "/src/CarritoCompras/TiendaServicios.API.CarritoCompras"
RUN dotnet build "TiendaServicios.API.CarritoCompras.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TiendaServicios.API.CarritoCompras.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TiendaServicios.API.CarritoCompras.dll"]
