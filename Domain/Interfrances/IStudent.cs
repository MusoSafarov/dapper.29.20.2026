using Domain.Models;

namespace Domain.Interfrances;

public interface IStudent
{
    bool AddStudent(Students student);
    bool UpdateStudent(Students student);
    bool DeleteStudent(int studentId);
    Students GetStudent(int studentId);
    List<Students> GetStudents();
}
