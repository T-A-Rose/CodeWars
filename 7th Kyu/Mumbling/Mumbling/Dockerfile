﻿FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Mumbling/Mumbling.csproj", "Mumbling/"]
RUN dotnet restore "Mumbling/Mumbling.csproj"
COPY . .
WORKDIR "/src/Mumbling"
RUN dotnet build "Mumbling.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Mumbling.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Mumbling.dll"]
