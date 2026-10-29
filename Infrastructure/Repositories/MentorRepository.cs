using Dapper;
using Domain.Interfrances;
using Domain.Models;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class MentorRepository(Database database):IMentors
{
     private Database _context = database;
    public bool AddMentor(Mentors MentoAddMentor)
    {
        using var connection = _context.Connection();
        connection.Open();
        var query = "insert into Mentors(fullname, email, phone, Enrollmentdate) values(@fullname, @email, @phone, @enrollmentdate)";
        var result = connection.Execute(query, MentoAddMentor);
        return result>0;
    }

    public bool DeleteMento(int MentoAddMentorId)
    {
        using var connection = _context.Connection();
        connection.Open();
        var query = "delete from Mentors where id=@MentoAddMentorid";
        var result = connection.Execute(query, new{MentoAddMentorId});
        return result>0;
    }

    public bool DeleteMentor(int MentorId)
    {
        throw new NotImplementedException();
    }


    public Mentors GetMento(int MentoAddMentorId)
    {
        using var connection = _context.Connection();
        connection.Open();
        var query = "select * from Mentors where id=@MentoAddMentorid";
        var result = connection.QuerySingle<Mentors>(query, new{MentoAddMentorId});
        return result;
    }

    public Mentors GetMentor(int MentorId)
    {
        throw new NotImplementedException();
    }


    public List<Mentors> GetMentors()
    {
        using var connection = _context.Connection();
        connection.Open();
        var query = "select * from Mentors";
        var result = connection.Query<Mentors>(query).ToList();
        return result;
    }

    public bool UpdateMentor(Mentors MentoAddMentor)
    {
        using var connection = _context.Connection();
        connection.Open();
        var query = "update Mentors set fullname=@fullname, email=@email, phone=@phone, Enrollmentdate=@enrollmentdate where id=@MentoAddMentorid";
        var result = connection.Execute(query, MentoAddMentor);
        return result>0;
    }
}
