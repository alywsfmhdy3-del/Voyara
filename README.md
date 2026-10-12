# Voyara 🏜️

Voyara is a platform built with a primary focus on Egyptian identity, aesthetics, and a premium user experience. The project maintains high technical integrity through Clean Architecture principles, ensuring a stable, performant, and scalable codebase.

## 🌟 Guiding Principles

- **Cultural Identity:** Voyara's design and content prioritize Egyptian aesthetics (Gold, Nile Blue, Sand) and visual excellence.
- **Technical Integrity:** Code is built to be stable and performant, strictly following Clean Architecture patterns.
- **User First:** Interfaces are designed to be intuitive, visually stunning, and responsive, featuring micro-animations and glassmorphism.

## 🏗️ Architecture & Tech Stack

Voyara is structured into a robust backend and a dynamic mobile frontend.

### Backend (.NET Core)
- **Framework:** .NET Core (C#)
- **Architecture:** Clean Architecture (Domain, Application, Infrastructure, API)
- **Database / ORM:** Entity Framework Core (Repository/Service pattern)
- **Validation:** FluentValidation
- **Security:** JWT-based authentication with role-based authorization.

### Frontend (Flutter)
- **Framework:** Flutter (Dart)
- **Architecture:** Feature-based Clean Architecture (Data, Domain, Presentation)
- **State Management:** Provider with `ChangeNotifier` (ViewModels)
- **Error Handling:** Functional error handling using `dartz` (Either)
- **Dependency Injection:** `get_it`

## 📂 Project Structure

```text
Voyara/
├── Voyara.Api/            # Presentation layer (Controllers, Middleware)
├── Voyara.Application/    # Business logic, Interfaces, DTOs
├── Voyara.Domain/         # Core business entities and exceptions
├── Voyara.Infrastructure/ # Data access, EF Core DbContext, external services
├── Voyara.Tests/          # Unit and integration tests
├── voyara_app/            # Flutter mobile application codebase
├── thesis/                # Project documentation / academic thesis
└── Scripts & SQL          # Utilities for fetching/updating Egyptian Governorates & Places
```

## 🚀 Getting Started

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download)
- [Flutter SDK](https://docs.flutter.dev/get-started/install)
- SQL Server (or your configured database provider)

### Backend Setup
1. Navigate to the API folder or root solution.
2. Ensure your database connection string is configured in `appsettings.json`.
3. Run migrations and start the backend:
   ```bash
   dotnet restore
   dotnet build
   dotnet run --project Voyara.Api
   ```

### Frontend Setup
1. Navigate to the `voyara_app` directory:
   ```bash
   cd voyara_app
   ```
2. Install dependencies:
   ```bash
   flutter pub get
   ```
3. Run the app on your preferred device or emulator:
   ```bash
   flutter run
   ```

## 🛠️ Scripts & Utilities
The root directory contains several PowerShell (`.ps1`) and SQL scripts (`.sql`). These are primarily used for managing and populating database records related to Egyptian governorates and places (e.g., `fetch_govs.ps1`, `update_govs.sql`).

## 📜 Constitution & Standards
All contributors must adhere to the [Voyara Project Constitution](PROJECT_CONSTITUTION.md), which outlines our coding standards, UI/UX aesthetics, and architectural guidelines.