#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Snater.Ocelot_API_Gateway/Snater.Ocelot_API_Gateway.csproj", "Snater.Ocelot_API_Gateway/"]
RUN dotnet restore "Snater.Ocelot_API_Gateway/Snater.Ocelot_API_Gateway.csproj"
COPY . .
WORKDIR "/src/Snater.Ocelot_API_Gateway"
RUN dotnet build "Snater.Ocelot_API_Gateway.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Snater.Ocelot_API_Gateway.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Snater.Ocelot_API_Gateway.dll"]