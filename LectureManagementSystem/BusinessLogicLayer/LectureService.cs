using LectureManagementSystem.DatabaseLogicLayer;

namespace LectureManagementSystem.BusinessLogicLayer;

/// <summary>
/// Business Logic Layer - validates input and applies the rules of the system
/// before handing work to the Database Logic Layer.
/// </summary>
public sealed class LectureService
{
    private readonly ILectureRepository _repository;

    public LectureService() : this(new LectureRepository())
    {
    }

    public LectureService(ILectureRepository repository) => _repository = repository;

    public List<Lecture> GetAll() => _repository.GetAll();

    public List<Lecture> Search(string term) =>
        string.IsNullOrWhiteSpace(term) ? _repository.GetAll() : _repository.Search(term.Trim());

    public Lecture? GetById(int id) => _repository.GetById(id);

    public int Add(Lecture lecture)
    {
        Validate(lecture);
        return _repository.Insert(lecture);
    }

    public void Update(Lecture lecture)
    {
        if (lecture.Id <= 0)
        {
            throw new ArgumentException("Please select a lecture to update.");
        }

        Validate(lecture);
        _repository.Update(lecture);
    }

    public void Delete(int id)
    {
        if (id <= 0)
        {
            throw new ArgumentException("Please select a lecture to delete.");
        }

        _repository.Delete(id);
    }

    private static void Validate(Lecture lecture)
    {
        if (string.IsNullOrWhiteSpace(lecture.Code))
        {
            throw new ArgumentException("Lecture code is required.");
        }

        if (string.IsNullOrWhiteSpace(lecture.Title))
        {
            throw new ArgumentException("Lecture title is required.");
        }

        if (string.IsNullOrWhiteSpace(lecture.LecturerName))
        {
            throw new ArgumentException("Lecturer name is required.");
        }

        if (lecture.Credits is <= 0 or > 20)
        {
            throw new ArgumentException("Credits must be between 1 and 20.");
        }
    }
}
