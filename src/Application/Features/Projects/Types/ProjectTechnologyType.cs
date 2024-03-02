using GraphQL.Types;
using MindworkingTest.Domain.Models;

namespace MindworkingTest.Application.Features.Projects.Types;

public sealed class ProjectTechnologyType : ObjectGraphType<ProjectTechnology>
{
    public ProjectTechnologyType()
    {
        Name = nameof(ProjectType);
        Description = "Projects worked on";
        Field(t => t.Id, nullable: false);
        Field(t => t.ProjectId, nullable: false)
            .Description("Project identifier");
        Field(t => t.TechnologyId, nullable: false)
            .Description("Technology identifier");
    }
}