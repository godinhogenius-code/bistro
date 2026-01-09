FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Bistro/Bistro.csproj", "Bistro/"]
RUN dotnet restore "Bistro/Bistro.csproj"
COPY . .
WORKDIR "/src/Bistro"
RUN dotnet build "Bistro.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Bistro.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_URLS=http://+:8080
ENTRYPOINT ["dotnet", "Bistro.dll"]
