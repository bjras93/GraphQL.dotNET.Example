using GraphQL.Types;
using Domain.Models;

namespace Application.Features.Projects.Types;

public class AddProjectTechnologyInputType : InputObjectGraphType<ProjectTechnology>
{
    public AddProjectTechnologyInputType()
    {
        Name = "AddProjectTechnologyInput";
        Field<NonNullGraphType<IntGraphType>>(nameof(ProjectTechnology.ProjectId));
        Field<NonNullGraphType<IntGraphType>>(nameof(ProjectTechnology.TechnologyId));
    }
}