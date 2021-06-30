#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
#EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Northwind.UI/Northwind.UI.csproj", "Northwind.UI/"]
COPY ["Northwind.Model/Northwind.Model.csproj", "Northwind.Model/"]
RUN dotnet restore "Northwind.UI/Northwind.UI.csproj"
COPY . .
WORKDIR "/src/Northwind.UI"
RUN dotnet build "Northwind.UI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Northwind.UI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Northwind.UI.dll"]
