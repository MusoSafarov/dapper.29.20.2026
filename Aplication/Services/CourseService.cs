using Aplication.Iterfrances;
using Domain.Models;
using Infrastructure.Repositories;

namespace Aplication.Services;

public class CourseService(CourseRepository courseRepository) : ICourseService
{
    private CourseRepository _repo = courseRepository;
    public async Task AddCourseAsync(Courses student)
    {
        var res = await _repo.AddCourseAsync(student);
        if(res)System.Console.WriteLine("Added!");
        else System.Console.WriteLine("Error!");
    }

    public async Task DeleteCourseAsync(int studentId)
    {
        var res = await _repo.DeleteCourseAsync(studentId);
        if(res)System.Console.WriteLine("Deleted!");
        else System.Console.WriteLine("Error");
    }

    public async Task GetCourseAsync(int studentId)
    {
        await _repo.GetCourseAsync(studentId);
    }

    public async Task GetCoursesAsync()
    {
        await _repo.GetCoursesAsync();   
    }

    public async Task UpdateCourseAsync(Courses student)
    {
        var res = await _repo.UpdateCourseAsync(student);
        if(res )System.Console.WriteLine("Updated!");
        else System.Console.WriteLine("Error!"); 
    }

}
