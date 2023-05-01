FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/Notification.Web.Host/Notification.Web.Host.csproj", "src/Notification.Web.Host/"]
COPY ["src/Notification.Web.Core/Notification.Web.Core.csproj", "src/Notification.Web.Core/"]
COPY ["src/Notification.Application/Notification.Application.csproj", "src/Notification.Application/"]
COPY ["src/Notification.Core/Notification.Core.csproj", "src/Notification.Core/"]
COPY ["src/Notification.EntityFrameworkCore/Notification.EntityFrameworkCore.csproj", "src/Notification.EntityFrameworkCore/"]
WORKDIR "/src/src/Notification.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/Notification.Web.Host", "src/Notification.Web.Host"]
COPY ["src/Notification.Web.Core", "src/Notification.Web.Core"]
COPY ["src/Notification.Application", "src/Notification.Application"]
COPY ["src/Notification.Core", "src/Notification.Core"]
COPY ["src/Notification.EntityFrameworkCore", "src/Notification.EntityFrameworkCore"]
WORKDIR "/src/src/Notification.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "Notification.Web.Host.dll"]
