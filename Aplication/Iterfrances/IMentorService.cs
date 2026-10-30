using Domain.Models;

namespace Aplication.Iterfrances;

public interface IMentorService
{
    Task  AddMentorAsync(Mentors Mentor);
    Task  UpdateMentorAsync(Mentors Mentor);
    Task  DeleteMentorAsync(int MentorId);
    Task  GetMentorAsync(int MentorId);
    Task  GetMentorsAsync();
}
