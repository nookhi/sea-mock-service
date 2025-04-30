# Используем базовый образ .NET runtime
FROM mcr.microsoft.com/dotnet/runtime:6.0 AS runtime

# Устанавливаем рабочую директорию в контейнере
WORKDIR /app

# Копируем опубликованные файлы приложения
COPY --from=build /app/out .

# Открываем порт 80
EXPOSE 80

# Указываем команду запуска приложения
ENTRYPOINT ["dotnet", "DocumentServiceMock.dll"]