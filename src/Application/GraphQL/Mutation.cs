using GraphQL.Types;
using MindworkingTest.Application.Features.Companies;
using MindworkingTest.Application.Features.Educations;
using MindworkingTest.Application.Features.Projects;
using MindworkingTest.Application.Features.Skills;
using MindworkingTest.Application.Features.Technologies;

namespace MindworkingTest.Application.GraphQL;

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