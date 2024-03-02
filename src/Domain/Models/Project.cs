namespace MindworkingTest.Domain.Models;

public sealed class Project
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required DateTime StartDate { get; set; }
    public required DateTime? EndDate { get; set; }
    public IEnumerable<Technology>? Technologies { get; set; }
    public static Project Create(Project project)
    => new()
    {
        Title = project.Title,
        Description = project.Description,
        StartDate = project.StartDate,
        EndDate = project.EndDate
    };
}