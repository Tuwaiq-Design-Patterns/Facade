FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["FacadService/FacadService.csproj", "FacadService/"]
RUN dotnet restore "FacadService/FacadService.csproj"
COPY . .
WORKDIR "/src/FacadService"
RUN dotnet build "FacadService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FacadService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FacadService.dll"]
