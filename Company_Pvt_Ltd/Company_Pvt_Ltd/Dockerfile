#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Company_Pvt_Ltd/Company_Pvt_Ltd.csproj", "Company_Pvt_Ltd/"]
RUN dotnet restore "Company_Pvt_Ltd/Company_Pvt_Ltd.csproj"
COPY . .
WORKDIR "/src/Company_Pvt_Ltd"
RUN dotnet build "Company_Pvt_Ltd.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Company_Pvt_Ltd.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Company_Pvt_Ltd.dll"]