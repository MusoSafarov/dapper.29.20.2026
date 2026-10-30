using Aplication.Iterfrances;
using Domain.Models;
using Infrastructure.Repositories;

namespace Aplication.Services;

public class StudentService(StudentRepository studentRepository) : IStudentService
{
    private StudentRepository _repo = studentRepository;
    public async Task AddStudentAsync(Students student)
    {
        var res = await _repo.AddStudentAsync(student);
        if(res)System.Console.WriteLine("Adde!");
        else System.Console.WriteLine("Error!");
    }

    public async Task DeleteStudentAsync(int studentId)
    {
        var res = await _repo.DeleteStudentAsync(studentId);
        if (res)System.Console.WriteLine("Deleted!");
        else System.Console.WriteLine("Error!");
    }

    public async Task GetStudentAsync(int studentId)
    {
        await _repo.GetStudentAsync(studentId);
    }

    public async Task GetStudentsAsync()
    {
        await _repo.GetStudentsAsync();
    }

    public async Task UpdateStudentAsync(Students student)
    {
        var res = await _repo.UpdateStudentAsync(student);
        if(res)System.Console.WriteLine("Updated!");
        else System.Console.WriteLine("Error!");
    }

}
