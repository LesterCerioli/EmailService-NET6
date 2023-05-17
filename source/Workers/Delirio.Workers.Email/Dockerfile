#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["source/Workers/Delirio.Workers.Email/Delirio.Workers.Email.csproj", "source/Workers/Delirio.Workers.Email/"]
RUN dotnet restore "source/Workers/Delirio.Workers.Email/Delirio.Workers.Email.csproj"
COPY . .
WORKDIR "/src/source/Workers/Delirio.Workers.Email"
RUN dotnet build "Delirio.Workers.Email.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Delirio.Workers.Email.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Delirio.Workers.Email.dll"]