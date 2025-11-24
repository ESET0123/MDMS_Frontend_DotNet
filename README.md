# MDMS Frontend (.NET)

This is the frontend application for the MDMS (Master Data Management System), built with ASP.NET Core MVC targeting .NET 8.0.

## Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

## Getting Started

### 1. Clone the repository

```bash
git clone <repository-url>
cd MDMS_Frontend_DotNet
```

### 2. Configuration

The application connects to a backend API. You can configure the API base URL in two ways:

**Option A: Environment Variable**
Set the `API_BASE_URL` environment variable.

**Option B: appsettings.json**
Add the `Api:BaseUrl` setting to your `appsettings.json` (or `appsettings.Development.json`):

```json
{
  "Api": {
    "BaseUrl": "https://your-api-url"
  }
}
```

*Default: `https://localhost:7272`*

### 3. Run the Application

```bash
dotnet run
```

The application will start and listen on the configured ports (usually `http://localhost:5000` or `https://localhost:5001`).
Navigate to `https://localhost:5001` (or the URL shown in the console) to access the application.

## Project Structure

- **Controllers**: MVC Controllers handling user requests.
- **Models**: Data models and view models.
- **Views**: Razor views for the UI.
- **wwwroot**: Static assets (CSS, JS, images).
- **Program.cs**: Application entry point and configuration.

## Key Features

- **Authentication**: JWT-based authentication (referenced in dependencies).
- **MVC Architecture**: Follows standard ASP.NET Core MVC patterns.
- **Runtime Compilation**: Razor runtime compilation is enabled.
