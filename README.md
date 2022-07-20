# dotnet-api

## Ordering Service

Folder Structure
================

├── Ordering.sln
├── README.md
├── src
│   └── Ordering
│       ├── Ordering.API
│       │   ├── Controllers
│       │   │   └── OrderingController.cs
│       │   ├── Ordering.API.csproj
│       │   ├── Program.cs
│       │   ├── Properties
│       │   │   └── launchSettings.json
│       │   ├── Ordering.cs
│       │   ├── appsettings.Development.json
│       │   ├── appsettings.json
│       ├── Ordering.Domain
│       │   ├── Class1.cs
│       │   ├── Ordering.Domain.csproj
│       └── Ordering.Infrastructure
│           ├── Class1.cs
│           ├── Ordering.Infrastructure.csproj
└── test

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

