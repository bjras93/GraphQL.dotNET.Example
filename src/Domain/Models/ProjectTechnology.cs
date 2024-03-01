using MindworkingTest.Domain.Enums;

namespace MindworkingTest.Domain.Models;

public sealed class ProjectTechnology
{
    public required string Name { get; set; }
    public required ProficiencyLevels ProficiencyLevel { get; set; }
    public required int ProjectId { get; set; }
    public required int TechnologyId { get; set; }
}