FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["src/HelloDevOps/HelloDevOps.csproj", "src/HelloDevOps/"]
RUN dotnet restore "src/HelloDevOps/HelloDevOps.csproj"
COPY . .
WORKDIR "/src/src/HelloDevOps"
RUN dotnet publish "HelloDevOps.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "HelloDevOps.dll"]