using Dapper;
using Domain.Interfrances;
using Domain.Models;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class MentorRepository(Database database):IMentors
{
     private Database _context = database;
    public async  Task <bool> AddMentorAsync(Mentors Mentor)
    {
        using var connection = _context.Connection();
        connection.Open();
        var query = "insert into Mentors(fullname, email, phone, specialization) values(@fullname, @email, @phone, @specialization)";
        var result = await connection.ExecuteAsync(query, Mentor);
        return result>0;
    }

    public async Task <bool> DeleteMentorAsync(int MentorId)
    {
        using var connection = _context.Connection();
        connection.Open();
        var query = "delete from Mentors where id=@Mentorid";
        var result = await connection.ExecuteAsync(query, new{MentorId});
        return result>0;
    }


    public async  Task <Mentors> GetMentorAsync(int MentorId)
    {
        using var connection = _context.Connection();
        connection.Open();
        var query = "select * from Mentors where id=@Mentorid";
        var result = await connection.QuerySingleAsync<Mentors>(query, new{MentorId});
        return result;
    } 


    public async  Task <List<Mentors>> GetMentorsAsync()
    {
        using var connection = _context.Connection();
        connection.Open();
        var query = "select * from Mentors";
        var result = await connection.QueryAsync<Mentors>(query);
        return result.ToList();
    }

    public async  Task <bool> UpdateMentorAsync(Mentors Mentor)
    {
        using var connection = _context.Connection();
        connection.Open();
        var query = "update Mentors set fullname=@fullname, email=@email, phone=@phone, specialization=@specialization where id=@Mentorid";
        var result = await connection.ExecuteAsync(query, Mentor);
        return result>0;
    }
}
