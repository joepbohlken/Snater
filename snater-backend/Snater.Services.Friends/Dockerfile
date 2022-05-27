#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Snater.Services.Friends/Snater.Services.Friends.csproj", "Snater.Services.Friends/"]
RUN dotnet restore "Snater.Services.Friends/Snater.Services.Friends.csproj"
COPY . .
WORKDIR "/src/Snater.Services.Friends"
RUN dotnet build "Snater.Services.Friends.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Snater.Services.Friends.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Snater.Services.Friends.dll"]