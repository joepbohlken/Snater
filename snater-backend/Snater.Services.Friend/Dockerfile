#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Snater.Services.Friend/Snater.Services.Friend.csproj", "Snater.Services.Friend/"]
RUN dotnet restore "Snater.Services.Friend/Snater.Services.Friend.csproj"
COPY . .
WORKDIR "/src/Snater.Services.Friend"
RUN dotnet build "Snater.Services.Friend.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Snater.Services.Friend.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Snater.Services.Friend.dll"]