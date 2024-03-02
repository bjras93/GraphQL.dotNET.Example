using GraphQL.Types;
using MindworkingTest.Application.Features.Projects;
using MindworkingTest.Application.Features.Technologies;

namespace MindworkingTest.Application.GraphQL;

public sealed class Mutation : ObjectGraphType
{
    public Mutation()
    {
        Field<TechnologyMutation>("technology").Resolve(context => new { });
        Field<ProjectMutation>("project").Resolve(context => new { });
    }
}