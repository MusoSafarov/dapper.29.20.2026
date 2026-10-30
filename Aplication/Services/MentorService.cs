using Aplication.Iterfrances;
using Domain.Models;
using Infrastructure.Repositories;

namespace Aplication.Services;

public class MentorService(MentorRepository mentorRepository) : IMentorService
{
    private MentorRepository rr = mentorRepository;
    public async Task AddMentorAsync(Mentors Mentor)
    {
        var res = await rr.AddMentorAsync(Mentor);
        if(res)System.Console.WriteLine("Addded!");
        else System.Console.WriteLine("Error!");
    }

    public async Task DeleteMentorAsync(int MentorId)
    {
        var res = await rr.DeleteMentorAsync(MentorId);
    }

    public async Task GetMentorAsync(int MentorId)
    {
        await rr.GetMentorAsync(MentorId);
    }

    public async Task GetMentorsAsync()
    {
        await rr.GetMentorsAsync();
    }

    public async Task UpdateMentorAsync(Mentors Mentor)
    {
        var res = await rr.UpdateMentorAsync(Mentor);
        if(res)System.Console.WriteLine("Updated!");
        else System.Console.WriteLine("Error!");
    }

}
