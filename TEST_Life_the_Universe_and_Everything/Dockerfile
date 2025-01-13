FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["TEST_Life_the_Universe_and_Everything/TEST_Life_the_Universe_and_Everything.csproj", "TEST_Life_the_Universe_and_Everything/"]
RUN dotnet restore "TEST_Life_the_Universe_and_Everything/TEST_Life_the_Universe_and_Everything.csproj"
COPY . .
WORKDIR "/src/TEST_Life_the_Universe_and_Everything"
RUN dotnet build "TEST_Life_the_Universe_and_Everything.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "TEST_Life_the_Universe_and_Everything.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TEST_Life_the_Universe_and_Everything.dll"]
