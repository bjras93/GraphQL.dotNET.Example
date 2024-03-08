using GraphQL.Types;
using Application.Features.Companies;
using Application.Features.Educations;
using Application.Features.Projects;
using Application.Features.Skills;
using Application.Features.Technologies;

namespace Application.GraphQL;

public sealed class Mutation : ObjectGraphType
{
    public Mutation()
    {
        Field<TechnologyMutation>("technologies").Resolve(context => new { });
        Field<ProjectMutation>("projects").Resolve(context => new { });
        Field<CompanyMutation>("companies").Resolve(context => new { });
        Field<SkillMutation>("skills").Resolve(context => new { });
        Field<EducationMutation>("educations").Resolve(context => new { });
    }
}