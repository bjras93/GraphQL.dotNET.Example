using MindworkingTest.Domain.Enums;
using MindworkingTest.Domain.Models;
using MindworkingTest.Repository.Tables;

namespace MindworkingTest.Application.Mappers;

public static class SkillMapper
{
    public static Skill Map(SkillTable table)
    => new()
    {
        ExperienceYears = table.ExperienceYears,
        ProficiencyLevel = (ProficiencyLevels)table.ProficiencyLevel,
        ReferenceId = table.ReferenceId,
        ReferenceType = (SkillTypes)table.ReferenceType
    };
    public static IEnumerable<Skill> Map(
        IEnumerable<SkillTable> tableRows)
    => tableRows.Select(Map).ToArray();
}