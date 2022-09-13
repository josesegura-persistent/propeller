FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["PropellerService/PropellerService.csproj", "PropellerService/"]
RUN dotnet restore "PropellerService/PropellerService.csproj"
COPY . .
WORKDIR "/src/PropellerService"
RUN dotnet build "PropellerService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PropellerService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_URLS=http://+:7002
ENV ASPNETCORE_ENVIRONMENT="Production"
ENTRYPOINT ["dotnet", "PropellerService.dll"]
