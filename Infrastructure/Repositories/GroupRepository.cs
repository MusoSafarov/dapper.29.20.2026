using System.Text.RegularExpressions;
using Dapper;
using Domain.Enum;
using Domain.Interfrances;
using Domain.Models;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class GroupRepository(Database database):IGroups
{
    private Database _context = database;
    public  async Task < bool> AddGroupAsync(Groups group)
    {
        using var connection = _context.Connection();
        connection.Open();
        var query = "insert into Groups(groupname,courseid, mentorid,startdate,enddate) values(groupname = @groupname, courseid= @courseid, mentorid = @mentorid, startdate = @startdate, enddate = @enddate)";
        var result = await connection.ExecuteAsync(query, group);
        return result>0;
    }

    public async Task < bool> DeleteGroupAsync(int groupId)
    {
        using var connection = _context.Connection();
        connection.Open();
        var query = "delete from Groups where id=@groupid";
        var result = await connection.ExecuteAsync(query, new{groupId});
        return result>0;
    }

    public async Task < Groups> GetGroupAsync(int groupId)
    {
        using var connection = _context.Connection();
        connection.Open();
        var query = "select * from Groups where id=@Groupid";
        var result = await connection.QuerySingleAsync<Groups>(query, new{groupId});
        return result;
    }

    public async Task < List<Groups>> GetGroupsAsync()
    {
        using var connection = _context.Connection();
        connection.Open();
        var query = "select * from Groups";
        var result = await connection.QueryAsync<Groups>(query);
        return result.ToList();
    }

    public async Task < bool> UpdateGroupAsync(Groups group)
    {
        using var connection = _context.Connection();
        connection.Open();
        var query = "update Groups set groupname = @groupname, courseid = @courseid, mentorid = @mentorid, startdate = @startdate, enddate = @enddate  where id=@Groupid";
        var result = await connection.ExecuteAsync(query, group);
        return result>0;
    }
}
