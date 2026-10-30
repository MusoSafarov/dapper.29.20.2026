using Dapper;
using Domain.Interfrances;
using Domain.Models;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class StudentGroupRepository(Database database):IStudentGroup
{
     private Database _context = database;

    public async Task<bool> AddStudentGroupAsync(StudentGroup student)
    {
        using var connection = _context.Connection();
        connection.Open();
        var query = "insert into studentgroups(studentid,groupid,status) values(studentid = @studentid,groupid = @groupid, status = @status)";
        var result = await connection.ExecuteAsync(query, student);
        return result>0;
    }

    public async Task<bool> DeleteStudentGroupAsync(int studentId)
    {
        using var connection = _context.Connection();
        connection.Open();
        var query = "delete from studentgroups where id=@studentid";
        var result = await connection.ExecuteAsync(query, new{studentId});
        return result>0;
    }

    public async Task<StudentGroup> GetStudentGroupAsync(int studentId)
    {
        using var connection = _context.Connection();
        connection.Open();
        var query = "select * from studentgroups where id=@studentid";
        var result = await connection.QuerySingleAsync<StudentGroup>(query, new{studentId});
        return result;
    }

    public async Task<List<StudentGroup>> GetStudentGroupsAsync()
    {
        using var connection = _context.Connection();
        connection.Open();
        var query = "select * from studentgroups";
        var result = await connection.QueryAsync<StudentGroup>(query);
        return result.ToList();
    }

    public async Task<bool> UpdateStudentGroupAsync(StudentGroup student)
    {
        using var connection = _context.Connection();
        connection.Open();
        var query = "update studentgroups set studentid = @studentid, groupid = @groupid, status = @status where id=@studentid";
        var result = await connection.ExecuteAsync(query, student);
        return result>0;
    }

}
