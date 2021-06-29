FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Facade/Facade.csproj", "Facade/"]
RUN dotnet restore "Facade/Facade.csproj"
COPY . .
WORKDIR "/src/Facade"
RUN dotnet build "Facade.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Facade.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Facade.dll"]
