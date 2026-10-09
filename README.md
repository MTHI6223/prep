# Lecture Management System

A Windows Forms application built with a classic three-layer architecture:

| Layer | Project folder | Responsibility |
|-------|----------------|----------------|
| Application Logic Layer | `LectureManagementSystem/ApplicationLogicLayer` | The WinForms UI (`MainForm`). Collects input, shows data, handles user events. Talks only to the Business Logic Layer. |
| Business Logic Layer | `LectureManagementSystem/BusinessLogicLayer` | `Lecture` entity and `LectureService`. Validates input and applies the rules of the system. Talks only to the Database Logic Layer. |
| Database Logic Layer | `LectureManagementSystem/DatabaseLogicLayer` | `Db` (connection) and `LectureRepository` (parameterised ADO.NET SQL). The only layer that knows about SQL Server. |

```
MainForm (UI)  ->  LectureService (BLL)  ->  LectureRepository (DAL)  ->  SQL Server
```

## Requirements

- Windows
- .NET 10 SDK (or a newer version)
- SQL Server, SQL Server Express, or SQL Server LocalDB

## Setup

1. Create the database and sample data. With `sqlcmd`:

   ```powershell
   sqlcmd -S "(localdb)\MSSQLLocalDB" -i "Database\Setup.sql"
   ```

   Or open `Database/Setup.sql` in SQL Server Management Studio / Azure Data Studio and execute it.

2. If you use a different SQL Server instance, update the connection string in
   `LectureManagementSystem/DatabaseLogicLayer/Db.cs`.

3. Build and run:

   ```powershell
   dotnet build
   dotnet run --project LectureManagementSystem
   ```

## Using the app

- Fill in the lecture details on the left and click **Add**.
- Click a row in the grid to load it, edit the fields, then click **Update**.
- Select a row and click **Delete** to remove it.
- Type in the search box and press **Enter** (or click **Search**) to filter.
- **Clear** empties the form, **Refresh** reloads everything.

## Notes on the layering

- The UI never contains SQL strings.
- The Business layer never touches a `SqlConnection`.
- The Database layer never contains validation or UI logic.
- Repository access goes through `ILectureRepository`, so the Business layer can be
  unit tested with a fake repository instead of a real database.
