# 1. Сборка
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY *.csproj ./
RUN dotnet restore
COPY . .
RUN dotnet publish -c Release -o /app

# 2. Запуск
FROM mcr.microsoft.com/dotnet/runtime:6.0 AS runtime
WORKDIR /app
COPY --from=build /app .

# Открываем порт
EXPOSE 80

# Точка входа
ENTRYPOINT ["dotnet", "DocumentServiceMock.dll"]