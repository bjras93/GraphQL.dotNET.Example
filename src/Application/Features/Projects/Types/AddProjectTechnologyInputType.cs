using GraphQL.Types;
using Domain.Models;

namespace Application.Features.Projects.Types;

public class AddProjectTechnologyInputType : InputObjectGraphType<ProjectTechnology>
{
    public AddProjectTechnologyInputType()
    {
        Name = "AddProjectTechnologyInput";
        Field<NonNullGraphType<IntGraphType>>("technologyId");
        Field<NonNullGraphType<IntGraphType>>("projectId");
    }
}