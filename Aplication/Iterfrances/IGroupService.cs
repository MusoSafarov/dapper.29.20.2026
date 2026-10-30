using Domain.Models;

namespace Aplication.Iterfrances;

public interface IGroupService
{
    Task  AddGroupAsync(Groups group);
    Task  UpdateGroupAsync(Groups group);
    Task  DeleteGroupAsync(int groupId);
    Task  GetGroupAsync(int groupId);
    Task  GetGroupsAsync();
}
