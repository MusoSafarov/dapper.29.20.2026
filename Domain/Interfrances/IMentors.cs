using Domain.Models;

namespace Domain.Interfrances;

public interface IMentors
{
    bool AddMentor(Mentors Mentor);
    bool UpdateMentor(Mentors Mentor);
    bool DeleteMentor(int MentorId);
    Mentors GetMentor(int MentorId);
    List<Mentors> GetMentors();
}
