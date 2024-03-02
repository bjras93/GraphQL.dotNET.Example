using MindworkingTest.Domain.Models;
using MindworkingTest.Repository.Tables;

namespace MindworkingTest.Application.Mappers;

public static class SkillTableMapper
{
    /// <summary>
    /// Creates new instance of <see cref="SkillTable"/> from <see cref="Skill"/>
    /// </summary>
    /// <returns>New instance of <see cref="SkillTable"/></returns>
    public static SkillTable Map(Skill skill)
    => new()
    {
        ExperienceYears = skill.ExperienceYears,
        ProficiencyLevel = (int)skill.ProficiencyLevel,
        ReferenceId = skill.ReferenceId,
        ReferenceType = (int)skill.ReferenceType
    };
}