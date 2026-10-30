using Domain.Models;

namespace Aplication.Iterfrances;

public interface IStudentService
{
    Task  AddStudentAsync(Students student);
    Task  UpdateStudentAsync(Students student);
    Task  DeleteStudentAsync(int studentId);
    Task  GetStudentAsync(int studentId);
    Task  GetStudentsAsync();
}
