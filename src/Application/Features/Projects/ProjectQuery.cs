using GraphQL;
using GraphQL.Types;
using Application.Features.Projects.Types;
using Application.Services;

namespace Application.Features.Projects;

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