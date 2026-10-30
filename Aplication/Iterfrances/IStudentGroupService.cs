using Domain.Models;

namespace Aplication.Iterfrances;

public interface IStudentGroupService
{
    Task  AddStudentGroupAsync(StudentGroup student);
    Task  UpdateStudentGroupAsync(StudentGroup student);
    Task  DeleteStudentGroupAsync(int studentId);
    Task  GetStudentGroupAsync(int studentId);
    Task  GetStudentGroupsAsync();
}
