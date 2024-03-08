using Domain.Enums;

namespace Domain.Models;

public sealed class Skill
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public required ProficiencyLevels ProficiencyLevel { get; set; }
    public required decimal ExperienceYears { get; set; }
    public required int ReferenceId { get; set; }
    public required SkillTypes ReferenceType { get; set; }
}