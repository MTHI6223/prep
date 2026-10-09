namespace LectureManagementSystem.BusinessLogicLayer;

/// <summary>
/// Business Logic Layer - the domain object the whole system works with.
/// </summary>
public class Lecture
{
    public int Id { get; set; }

    public string Code { get; set; } = string.Empty;

    public string Title { get; set; } = string.Empty;

    public string LecturerName { get; set; } = string.Empty;

    public string Department { get; set; } = string.Empty;

    public int Credits { get; set; }

    public string Semester { get; set; } = string.Empty;

    public string Schedule { get; set; } = string.Empty;
}
