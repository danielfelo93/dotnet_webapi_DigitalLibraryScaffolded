FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["./", "LIBRERIADIGITAL.WebApi"]
RUN dotnet restore "LIBRERIADIGITAL.WebApi/LIBRERIADIGITAL.WebApi.csproj"
COPY . .
WORKDIR "/src/LIBRERIADIGITAL.WebApi"
RUN dotnet build "LIBRERIADIGITAL.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LIBRERIADIGITAL.WebApi.csproj" -c release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LIBRERIADIGITAL.WebApi.dll"]
