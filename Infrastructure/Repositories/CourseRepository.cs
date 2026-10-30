using Dapper;
using Domain.Interfrances;
using Domain.Models;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class CourseRepository(Database database):ICourses
{
     private Database _context = database;
    public async Task <bool> AddCourseAsync(Courses Course)
    {
        using var connection = _context.Connection();
        connection.Open();
        var query = "insert into Courses(title,description,durationweeks) values(@title,@description,@durationweeks)";
        var result = await connection.ExecuteAsync(query, Course);
        return result>0;
    }

    public async Task <bool> DeleteCourseAsync(int CourseId)
    {
        using var connection = _context.Connection();
        connection.Open();
        var query = "delete from Courses where id=@Courseid";
        var result = await connection.ExecuteAsync(query, new{CourseId});
        return result>0;
    }

    public async Task <Courses> GetCourseAsync(int CourseId)
    {
        using var connection = _context.Connection();
        connection.Open();
        var query = "select * from Courses where id=@Courseid";
        var result = await connection.QuerySingleAsync<Courses>(query, new{CourseId});
        return result;
    }

    public async Task <List<Courses>> GetCoursesAsync()
    {
        using var connection = _context.Connection();
        connection.Open();
        var query = "select * from Courses";
        var result = await connection.QueryAsync<Courses>(query);
        return result.ToList();
    }


    public async Task <bool> UpdateCourseAsync(Courses Course)
    {
        using var connection = _context.Connection();
        connection.Open();
        var query = "update Courses set title = @title, description = @description, durationweeks = @durationweeks where id=@Courseid";
        var result = await connection.ExecuteAsync(query, Course);
        return result>0;
    }

}
