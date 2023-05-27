FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Admiral.Cockpit/Admiral.Cockpit.csproj", "Admiral.Cockpit/"]
RUN dotnet restore "Admiral.Cockpit/Admiral.Cockpit.csproj"
COPY . .
WORKDIR "/src/Admiral.Cockpit"
RUN dotnet build "Admiral.Cockpit.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Admiral.Cockpit.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Admiral.Cockpit.dll"]
