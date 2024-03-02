using GraphQL.Types;
using MindworkingTest.Domain.Models;

namespace MindworkingTest.Application.Features.CurriculumVitaes.Types;

public sealed class SkillType : ObjectGraphType<Skill>
{
    public SkillType()
    {
        Name = nameof(Skill);
        Description = "Skills to list on a curriculum vitae";
        Field(t => t.Name, nullable: false)
            .Description("Name of the skill");
    }
}