using Domain.Models;

namespace Domain.Interfrances;

public interface IStudentGroup
{
    Task <bool> AddStudentGroupAsync(StudentGroup student);
    Task <bool> UpdateStudentGroupAsync(StudentGroup student);
    Task <bool> DeleteStudentGroupAsync(int studentId);
    Task <StudentGroup> GetStudentGroupAsync(int studentId);
    Task <List<StudentGroup>> GetStudentGroupsAsync();
}
