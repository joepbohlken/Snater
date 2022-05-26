# De Dockerfile is opgebouwt uit verschillende lagen.

# Deze laag wordt later gebruikt om je applicatie mee te draaien.
# Je kan de poorten hier aanpassen, de 'EXPOSE' regels, als dat nodig is voor jouw applicatie.
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Deze laag bouwt jouw applicatie om te testen of alles werkt.
# Verander de 'APIGateway' met de naam van jouw project.
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY APIGateway.csproj ./
RUN dotnet restore APIGateway.csproj
COPY . .
RUN dotnet build APIGateway.csproj -c Release -o /app/build

# Deze laag bouwt een 'productie' versie van jouw applicatie.
# Verander de 'APIGateway' met de naam van jouw project.
FROM build AS publish
RUN dotnet publish APIGateway.csproj -c Release -o /app/publish

# Deze laag wordt gebruikt om de bestanden, voor de productie versie van jouw applicatie, te kopieren naar de Docker image.
# Verander de 'APIGateway' met de naam van jouw project.
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "APIGateway.dll"]