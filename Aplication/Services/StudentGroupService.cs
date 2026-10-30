using Aplication.Iterfrances;
using Domain.Models;
using Infrastructure.Repositories;

namespace Aplication.Services;

public class StudentGroupService(StudentGroupRepository studentGroupRepository) : IStudentGroupService
{
    private StudentGroupRepository rr = studentGroupRepository;
    public async Task AddStudentGroupAsync(StudentGroup student)
    {
        var res = await rr.AddStudentGroupAsync(student);
        if(res)System.Console.WriteLine("Added!");
        else System.Console.WriteLine("Error!");
    }

    public async Task DeleteStudentGroupAsync(int studentId)
    {
        var res = await rr.DeleteStudentGroupAsync(studentId);
        if(res)System.Console.WriteLine("Deleted!");
        else System.Console.WriteLine("Error!");
    }

    public async Task GetStudentGroupAsync(int studentId)
    {
        await rr.GetStudentGroupAsync(studentId);
    }

    public async Task GetStudentGroupsAsync()
    {
        await rr.GetStudentGroupsAsync();
    }

    public async Task UpdateStudentGroupAsync(StudentGroup student)
    {
        var res = await rr.UpdateStudentGroupAsync(student);
        if(res)System.Console.WriteLine("Updated!");
        else System.Console.WriteLine("Errror!");
    }

}
