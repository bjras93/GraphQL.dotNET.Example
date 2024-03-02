namespace MindworkingTest.Domain.Models;

public sealed class ProjectTechnology
{
    public int Id { get; set; }
    public int ProjectId { get; set; }
    public int TechnologyId { get; set; }
}