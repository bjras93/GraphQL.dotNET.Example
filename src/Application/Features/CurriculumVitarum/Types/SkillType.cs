using GraphQL.Types;
using MindworkingTest.Domain.Models;

namespace MindworkingTest.Application.Features.CurriculumVitarum.Types;

public sealed class SkillType : ObjectGraphType<Skill>
{
    public SkillType()
    {
        Name = nameof(Skill);
        Description = "Skills acquired";
        Field(t => t.Name, nullable: false)
            .Description("Name of the skill");
        Field(t => t.ProficiencyLevel, nullable: false)
            .Description("Proficiency with the skill");
        Field(t => t.ExperienceYears, nullable: false)
            .Description("Years of experience");
    }
}