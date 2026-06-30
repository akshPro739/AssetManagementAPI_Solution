# AssetManagementAPI_Solution

# Asset Management System

## Project Overview

The Asset Management System is a RESTful Web API developed using **ASP.NET Core 8**, **Entity Framework Core**, **SQL Server**, and **Onion Architecture**. It helps an organization manage and track organizational assets such as laptops, mobile phones, printers, sensors, chargers, and other devices.

The application provides user management, asset management, procurement tracking, and asset lifecycle management through a layered architecture.

---

## Technologies Used

- ASP.NET Core 8 Web API
- C#
- Entity Framework Core
- SQL Server
- Swagger (OpenAPI)
- Onion Architecture
- Repository Pattern
- Service Layer
- Dependency Injection
- Visual Studio 2022

---

## Project Architecture

```
AssetManagementSolution
│
├── DomainLayer
│   ├── Models
│   └── AssetManagementDbContext
│
├── RepositoryLayer
│   ├── Interfaces
│   └── Implementations
│
├── ServiceLayer
│   ├── Interfaces
│   └── Implementations
│
└── AssetManagementAPI
    ├── Controllers
    ├── ViewModels
    ├── Program.cs
    ├── appsettings.json
    └── Swagger
```


