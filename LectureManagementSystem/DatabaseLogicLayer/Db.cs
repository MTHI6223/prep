using Microsoft.Data.SqlClient;

namespace LectureManagementSystem.DatabaseLogicLayer;

/// <summary>
/// Database Logic Layer - single place that knows how to reach the database.
/// Change <see cref="ConnectionString"/> to point at your own SQL Server instance.
/// </summary>
public static class Db
{
    public static string ConnectionString { get; set; } =
        @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LectureDb;Integrated Security=True;TrustServerCertificate=True;";

    public static SqlConnection CreateConnection() => new(ConnectionString);

    /// <summary>Opens a connection and reports any failure without throwing.</summary>
    public static bool TestConnection(out string error)
    {
        try
        {
            using var connection = CreateConnection();
            connection.Open();
            error = string.Empty;
            return true;
        }
        catch (Exception ex)
        {
            error = ex.Message;
            return false;
        }
    }
}
