FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["Unians.Faculty.Api/Unians.Faculty.Api.csproj", "Unians.Faculty.Api/"]
RUN dotnet restore "Unians.Faculty.Api/Unians.Faculty.Api.csproj"
COPY . .
WORKDIR "/src/Unians.Faculty.Api"
RUN dotnet build "Unians.Faculty.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Unians.Faculty.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Unians.Faculty.Api.dll"]