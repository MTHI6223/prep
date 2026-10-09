using LectureManagementSystem.BusinessLogicLayer;

namespace LectureManagementSystem.DatabaseLogicLayer;

/// <summary>
/// Database Logic Layer - contract for persisting <see cref="Lecture"/> records.
/// Keeping it as an interface lets the Business Logic Layer be tested with a fake repository.
/// </summary>
public interface ILectureRepository
{
    List<Lecture> GetAll();

    List<Lecture> Search(string term);

    Lecture? GetById(int id);

    int Insert(Lecture lecture);

    bool Update(Lecture lecture);

    bool Delete(int id);
}
