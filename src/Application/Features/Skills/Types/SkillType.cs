using GraphQL.Types;
using MindworkingTest.Domain.Models;

namespace MindworkingTest.Application.Features.Skills.Types;

public sealed class SkillType : ObjectGraphType<Skill>
{
    public SkillType()
    {
        Field(s => s.ProficiencyLevel, nullable: false);
        Field(s => s.ExperienceYears, nullable: false);
        Field(s => s.ReferenceId, nullable: false);
        Field(s => s.ReferenceType, nullable: false);
    }
}