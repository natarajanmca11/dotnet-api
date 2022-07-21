# dotnet-api

## Ordering Service

[Sonarqube Report](https://sonarcloud.io/project/overview?id=natarajanmca11_dotnet-api)

Folder Structure
================
```
.
├── Ordering.Test.sln
├── Ordering.sln
├── README.md
├── src
│   └── Ordering
│       ├── Ordering.API
│       │   ├── Controllers
│       │   │   └── OrderingController.cs
│       │   ├── Ordering.API.csproj
│       │   ├── Program.cs
│       │   ├── Properties
│       │   │   └── launchSettings.json
│       │   ├── WeatherForecast.cs
│       │   ├── appsettings.Development.json
│       │   ├── appsettings.json
│       ├── Ordering.Domain
│       │   ├── Class1.cs
│       │   ├── Ordering.Domain.csproj
│       └── Ordering.Infrastructure
│           ├── Class1.cs
│           ├── Ordering.Infrastructure.csproj
├── test
│   └── Ordering
│       ├── Ordering.API.Test
│       │   ├── Ordering.API.Test.csproj
│       │   ├── UnitTest1.cs
│       ├── Ordering.Domain.Test
│       │   ├── Ordering.Domain.Test.csproj
│       │   ├── UnitTest1.cs
│       └── Ordering.Infrastructure.Test
│           ├── Ordering.Infrastructure.Test.csproj
│           ├── UnitTest1.cs

```

## Porjects Create Command

// Inside the Ordering folder

dotnet new webapi --name Ordering.API
dotnet new classlib --name Ordering.Domain  
dotnet new classlib --name Ordering.Infrastructure

// Root folder
dotnet new sln --name Ordering
dotnet sln add ./src/Ordering/Ordering.API
dotnet sln add ./src/Ordering/Ordering.Domain
dotnet sln add ./src/Ordering/Ordering.Infrastructure

// Create Test Projects

dotnet new xunit --name Ordering.API.Test
dotnet new xunit --name Ordering.Domain.Test
dotnet new xunit --name Ordering.Infrastructure.Test

// Root folder
dotnet new sln --name Ordering.Test
dotnet sln Ordering.Test.sln add ./test/Ordering/Ordering.API.Test
dotnet sln Ordering.Test.sln add ./test/Ordering/Ordering.Domain.Test
dotnet sln Ordering.Test.sln add ./test/Ordering/Ordering.Infrastructure.Test

## Container build

docker build -t ordering-service .