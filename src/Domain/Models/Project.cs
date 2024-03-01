namespace MindworkingTest.Domain.Models;

public sealed class Project
{
    public required int Id { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required int StartDate { get; set; }
    public required int EndDate { get; set; }
}