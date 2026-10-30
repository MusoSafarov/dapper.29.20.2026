using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Aplication.Iterfrances;
using Domain.Models;
using Infrastructure.Repositories;

namespace Aplication.Services;

public class GroupService(GroupRepository groupRepository) : IGroupService
{
    private GroupRepository rr = groupRepository;
    public async Task AddGroupAsync(Groups group)
    {
        var res = await rr.AddGroupAsync(group);
        if(res)System.Console.WriteLine("Added!");
        else System.Console.WriteLine("Error!");
    }

    public async Task DeleteGroupAsync(int groupId)
    {
        var res = await rr.DeleteGroupAsync(groupId);
        if(res)System.Console.WriteLine("Deleted!");
        else System.Console.WriteLine("Error!");
    }

    public async Task GetGroupAsync(int groupId)
    {
        await rr.GetGroupAsync(groupId);
    }

    public async Task GetGroupsAsync()
    {
        await rr.GetGroupsAsync();
    }

    public async Task UpdateGroupAsync(Groups group)
    {
        var res = await rr.UpdateGroupAsync(group);
        if(res)System.Console.WriteLine("Updated!");
        else System.Console.WriteLine("Error!");
    }

}
