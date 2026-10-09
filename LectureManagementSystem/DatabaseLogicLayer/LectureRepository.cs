using Microsoft.Data.SqlClient;
using LectureManagementSystem.BusinessLogicLayer;

namespace LectureManagementSystem.DatabaseLogicLayer;

/// <summary>
/// Database Logic Layer - all SQL for the Lectures table lives here.
/// Only parameterised commands are used to prevent SQL injection.
/// </summary>
public sealed class LectureRepository : ILectureRepository
{
    private const string Columns = "Id, Code, Title, LecturerName, Department, Credits, Semester, Schedule";

    public List<Lecture> GetAll()
    {
        var lectures = new List<Lecture>();

        using var connection = Db.CreateConnection();
        using var command = new SqlCommand($"SELECT {Columns} FROM dbo.Lectures ORDER BY Id;", connection);
        connection.Open();

        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            lectures.Add(Map(reader));
        }

        return lectures;
    }

    public List<Lecture> Search(string term)
    {
        var lectures = new List<Lecture>();

        using var connection = Db.CreateConnection();
        using var command = new SqlCommand(
            $@"SELECT {Columns} FROM dbo.Lectures
               WHERE Code LIKE @term OR Title LIKE @term OR LecturerName LIKE @term
                  OR Department LIKE @term OR Semester LIKE @term
               ORDER BY Id;", connection);
        command.Parameters.AddWithValue("@term", $"%{term}%");
        connection.Open();

        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            lectures.Add(Map(reader));
        }

        return lectures;
    }

    public Lecture? GetById(int id)
    {
        using var connection = Db.CreateConnection();
        using var command = new SqlCommand($"SELECT {Columns} FROM dbo.Lectures WHERE Id = @Id;", connection);
        command.Parameters.AddWithValue("@Id", id);
        connection.Open();

        using var reader = command.ExecuteReader();
        return reader.Read() ? Map(reader) : null;
    }

    public int Insert(Lecture lecture)
    {
        using var connection = Db.CreateConnection();
        using var command = new SqlCommand(
            @"INSERT INTO dbo.Lectures (Code, Title, LecturerName, Department, Credits, Semester, Schedule)
              OUTPUT INSERTED.Id
              VALUES (@Code, @Title, @LecturerName, @Department, @Credits, @Semester, @Schedule);", connection);
        AddParameters(command, lecture);
        connection.Open();

        return (int)command.ExecuteScalar();
    }

    public bool Update(Lecture lecture)
    {
        using var connection = Db.CreateConnection();
        using var command = new SqlCommand(
            @"UPDATE dbo.Lectures
              SET Code = @Code, Title = @Title, LecturerName = @LecturerName,
                  Department = @Department, Credits = @Credits, Semester = @Semester, Schedule = @Schedule
              WHERE Id = @Id;", connection);
        command.Parameters.AddWithValue("@Id", lecture.Id);
        AddParameters(command, lecture);
        connection.Open();

        return command.ExecuteNonQuery() > 0;
    }

    public bool Delete(int id)
    {
        using var connection = Db.CreateConnection();
        using var command = new SqlCommand("DELETE FROM dbo.Lectures WHERE Id = @Id;", connection);
        command.Parameters.AddWithValue("@Id", id);
        connection.Open();

        return command.ExecuteNonQuery() > 0;
    }

    private static void AddParameters(SqlCommand command, Lecture lecture)
    {
        command.Parameters.AddWithValue("@Code", lecture.Code);
        command.Parameters.AddWithValue("@Title", lecture.Title);
        command.Parameters.AddWithValue("@LecturerName", lecture.LecturerName);
        command.Parameters.AddWithValue("@Department", lecture.Department);
        command.Parameters.AddWithValue("@Credits", lecture.Credits);
        command.Parameters.AddWithValue("@Semester", lecture.Semester);
        command.Parameters.AddWithValue("@Schedule", lecture.Schedule);
    }

    private static Lecture Map(SqlDataReader reader) => new()
    {
        Id = reader.GetInt32(0),
        Code = reader.GetString(1),
        Title = reader.GetString(2),
        LecturerName = reader.GetString(3),
        Department = reader.GetString(4),
        Credits = reader.GetInt32(5),
        Semester = reader.GetString(6),
        Schedule = reader.GetString(7)
    };
}
