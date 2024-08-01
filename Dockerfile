# Etapa 1: Imagem base para a aplicação
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Etapa 2: Imagem de build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copiar o arquivo de projeto e restaurar as dependências
COPY ["src/Presentation.WebAPI/Presentation.WebAPI.csproj", "src/Presentation.WebAPI/"]
RUN dotnet restore "src/Presentation.WebAPI/Presentation.WebAPI.csproj"

# Copiar o restante dos arquivos e construir a aplicação
COPY . .
WORKDIR "/src/src/Presentation.WebAPI"
RUN dotnet build "Presentation.WebAPI.csproj" -c Release -o /app/build

# Etapa 3: Publicar a aplicação
FROM build AS publish
RUN dotnet publish "Presentation.WebAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Etapa 4: Configurar a imagem final
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Presentation.WebAPI.dll"]
