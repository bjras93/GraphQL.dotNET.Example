using GraphQL.Types;
using Domain.Models;

namespace Application.Features.CurriculumVitarum.Types;

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