FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["Faculty.Api/Faculty.Api.csproj", "Faculty.Api/"]
RUN dotnet restore "Faculty.Api/Faculty.Api.csproj"
COPY . .
WORKDIR "/src/Faculty.Api"
RUN dotnet build "Faculty.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Faculty.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Faculty.Api.dll"]