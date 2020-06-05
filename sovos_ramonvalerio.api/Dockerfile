#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["sovos_ramonvalerio.api/sovos_ramonvalerio.api.csproj", "sovos_ramonvalerio.api/"]
RUN dotnet restore "sovos_ramonvalerio.api/sovos_ramonvalerio.api.csproj"
COPY . .
WORKDIR "/src/sovos_ramonvalerio.api"
RUN dotnet build "sovos_ramonvalerio.api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "sovos_ramonvalerio.api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "sovos_ramonvalerio.api.dll"]