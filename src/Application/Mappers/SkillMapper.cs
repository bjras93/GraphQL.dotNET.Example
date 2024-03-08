using Domain.Enums;
using Domain.Models;
using Repository.Tables;

namespace Application.Mappers;

public static class SkillMapper
{
    /// <summary>
    /// Creates new instance of <see cref="Skill"/> from <see cref="SkillTable"/>
    /// </summary>
    /// <returns>New instance of <see cref="Skill"/></returns>
    public static Skill Map(SkillTable table)
    => new()
    {
        ExperienceYears = table.ExperienceYears,
        ProficiencyLevel = (ProficiencyLevels)table.ProficiencyLevel,
        ReferenceId = table.ReferenceId,
        ReferenceType = (SkillTypes)table.ReferenceType
    };
    /// <summary>
    /// Creates new instances of <see cref="Skill"/> from enumerable <see cref="SkillTable"/>
    /// </summary>
    /// <returns>List of <see cref="Skill"/></returns>
    public static IEnumerable<Skill> Map(
        IEnumerable<SkillTable> tableRows)
    => tableRows.Select(Map).ToList();
}