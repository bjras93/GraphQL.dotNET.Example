using GraphQL;
using GraphQL.Types;
using Application.Features.Projects.Types;
using Application.Features.Skills.Types;
using Application.Services;
using Domain.Models;

namespace Application.Features.Skills;

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