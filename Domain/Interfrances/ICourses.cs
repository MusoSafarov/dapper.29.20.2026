using Domain.Models;

namespace Domain.Interfrances;

public interface ICourses
{
    Task <bool> AddCourseAsync(Courses student);
    Task <bool> UpdateCourseAsync(Courses student);
    Task <bool> DeleteCourseAsync(int studentId);
    Task <Courses> GetCourseAsync(int studentId);
    Task <List<Courses>> GetCoursesAsync();
}
