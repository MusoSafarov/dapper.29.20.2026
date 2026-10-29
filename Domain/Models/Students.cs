namespace Domain.Models;

public class Students
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public DateOnly EnrollmentDate { get; set; }
}
