#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["LinkBakery.Web.Cms/LinkBakery.Web.Cms.csproj", "LinkBakery.Web.Cms/"]
RUN dotnet restore "LinkBakery.Web.Cms/LinkBakery.Web.Cms.csproj"
COPY . .
WORKDIR "/src/LinkBakery.Web.Cms"
RUN dotnet build "LinkBakery.Web.Cms.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LinkBakery.Web.Cms.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LinkBakery.Web.Cms.dll"]