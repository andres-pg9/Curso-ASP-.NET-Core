**Ejecución del Proyecto**

CRUD básico de productos usando ASP .NET Core, Entity Framework y SQLite

> [!IMPORTANT]
> El proyecto está desarrollado en .NET 8.0

Instalar las siguientes dependencias:
- dotnet add package Microsoft.EntityFrameworkCore
- dotnet add package Microsoft.EntityFrameworkCore.Design
- dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
- dotnet add package Microsoft.EntityFrameworkCore.Sqlite
- dotnet tool install --global dotnet-ef

Para crear las migraciones:
-dotnet ef migrations add MigracionInicial

> [!TIP]
> Se recomienda el uso de las extensiones C# Dev Kit, C# Extensions, .NET Install Tool y SQLite
