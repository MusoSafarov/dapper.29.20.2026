using Domain.Models;

namespace Domain.Interfrances;

public interface IStudent
{
    Task <bool> AddStudentAsync(Students student);
    Task <bool> UpdateStudentAsync(Students student);
    Task <bool> DeleteStudentAsync(int studentId);
    Task <Students> GetStudentAsync(int studentId);
    Task <List<Students>> GetStudentsAsync();
}
