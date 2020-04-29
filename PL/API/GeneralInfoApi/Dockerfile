#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#!!!! --- Debug/Release for debugging

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["PL/API/GeneralInfoApi/GeneralInfoApi.csproj", "PL/API/GeneralInfoApi/"]
RUN dotnet restore "PL/API/GeneralInfoApi/GeneralInfoApi.csproj"
COPY . .
WORKDIR "/src/PL/API/GeneralInfoApi"
RUN dotnet build "GeneralInfoApi.csproj" -c Debug -o /app/build

FROM build AS publish
RUN dotnet publish "GeneralInfoApi.csproj" -c Debug -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GeneralInfoApi.dll"]