using GraphQL.Types;
using Domain.Models;

namespace Application.Features.Projects.Types;

public sealed class ProjectTechnologyType : ObjectGraphType<ProjectTechnology>
{
    public ProjectTechnologyType()
    {
        Name = nameof(ProjectType);
        Description = "Projects worked on";
        Field<NonNullGraphType<IntGraphType>>(nameof(ProjectTechnology.Id));
        Field<NonNullGraphType<IntGraphType>>(nameof(ProjectTechnology.ProjectId));
        Field<NonNullGraphType<IntGraphType>>(nameof(ProjectTechnology.TechnologyId));
    }
}