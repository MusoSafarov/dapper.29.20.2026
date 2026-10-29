using Dapper;
using Domain.Interfrances;
using Domain.Models;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class CourseRepository(Database database):ICourses
{
     private Database _context = database;
    public bool AddCourse(Courses Course)
    {
        using var connection = _context.Connection();
        connection.Open();
        var query = "insert into Courses(title,description,durationweeks) values(@title,@description,@durationweeks)";
        var result = connection.Execute(query, Course);
        return result>0;
    }

    public bool DeleteCourse(int CourseId)
    {
        using var connection = _context.Connection();
        connection.Open();
        var query = "delete from Courses where id=@Courseid";
        var result = connection.Execute(query, new{CourseId});
        return result>0;
    }

    public Courses GetCourse(int CourseId)
    {
        using var connection = _context.Connection();
        connection.Open();
        var query = "select * from Courses where id=@Courseid";
        var result = connection.QuerySingle<Courses>(query, new{CourseId});
        return result;
    }

    public List<Courses> GetCourses()
    {
        using var connection = _context.Connection();
        connection.Open();
        var query = "select * from Courses";
        var result = connection.Query<Courses>(query).ToList();
        return result;
    }


    public bool UpdateCourse(Courses Course)
    {
        using var connection = _context.Connection();
        connection.Open();
        var query = "update Courses set fullname=@fullname, email=@email, phone=@phone, Enrollmentdate=@enrollmentdate where id=@Courseid";
        var result = connection.Execute(query, Course);
        return result>0;
    }

}
