using Domain.Models;

namespace Domain.Interfrances;

public interface IMentors
{
    Task <bool> AddMentorAsync(Mentors Mentor);
    Task <bool> UpdateMentorAsync(Mentors Mentor);
    Task <bool> DeleteMentorAsync(int MentorId);
    Task <Mentors> GetMentorAsync(int MentorId);
    Task <List<Mentors>> GetMentorsAsync();
}