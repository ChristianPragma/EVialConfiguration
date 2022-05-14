#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["EVialConfig.Api/EVialConfig.Api.csproj", "EVialConfig.Api/"]
RUN dotnet restore "EVialConfig.Api/EVialConfig.Api.csproj"
COPY . .
WORKDIR "/src/EVialConfig.Api"
RUN dotnet build "EVialConfig.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EVialConfig.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EVialConfig.Api.dll"]