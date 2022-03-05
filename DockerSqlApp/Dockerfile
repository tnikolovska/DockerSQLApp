#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DockerSqlApp/DockerSqlApp.csproj", "DockerSqlApp/"]
RUN dotnet restore "DockerSqlApp/DockerSqlApp.csproj"
COPY . .
WORKDIR "/src/DockerSqlApp"
RUN dotnet build "DockerSqlApp.csproj" -c Release -o /app/build

# Dev-ready container - actual files will be mounted in
FROM base AS dev
CMD ["mkdocs", "serve", "-a", "0.0.0.0:8000"]

FROM build AS publish
RUN dotnet publish "DockerSqlApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DockerSqlApp.dll"]
