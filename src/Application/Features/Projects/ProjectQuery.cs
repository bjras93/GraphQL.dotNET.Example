using GraphQL;
using GraphQL.Types;
using MindworkingTest.Application.Features.Projects.Types;
using MindworkingTest.Application.Services;

namespace MindworkingTest.Application.Features.Projects;

public sealed class ProjectQuery : ObjectGraphType
{
    public ProjectQuery(IProjectService service)
    {
        Field<ListGraphType<ProjectType>>("projects")
        .ResolveAsync(async context =>
        {
            var projects = await service.GetAsync();
            return projects;
        });
    }
}