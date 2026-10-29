using Domain.Models;

namespace Domain.Interfrances;

public interface ICourses
{
    bool AddCourse(Courses student);
    bool UpdateCourse(Courses student);
    bool DeleteCourse(int studentId);
    Courses GetCourse(int studentId);
    List<Courses> GetCourses();
}
