using GraphQL;
using GraphQL.Types;
using MindworkingTest.Application.Features.Projects.Types;
using MindworkingTest.Application.Features.Skills.Types;
using MindworkingTest.Application.Services;
using MindworkingTest.Domain.Models;

namespace MindworkingTest.Application.Features.Skills;

public sealed class SkillMutation : ObjectGraphType
{
    public SkillMutation(
        ISkillService service,
        ITechnologyService technologyService)
    {
        Field<SkillType>(
            "createSkill")
            .Argument<NonNullGraphType<SkillInputType>>("skill")
            .ResolveAsync(async context =>
            {
                var input = context.GetArgument<Skill>("skill");

                var project = new Skill
                {
                    ProficiencyLevel = input.ProficiencyLevel,
                    ExperienceYears = input.ExperienceYears,
                    ReferenceId = input.ReferenceId,
                    ReferenceType = input.ReferenceType
                };
                var createdProject = await service.CreateAsync(project);

                return createdProject;
            });
    }
}