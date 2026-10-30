using Domain.Models;

namespace Aplication.Iterfrances;

public interface ICourseService
{
    Task  AddCourseAsync(Courses student);
    Task  UpdateCourseAsync(Courses student);
    Task  DeleteCourseAsync(int studentId);
    Task  GetCourseAsync(int studentId);
    Task  GetCoursesAsync();
}
