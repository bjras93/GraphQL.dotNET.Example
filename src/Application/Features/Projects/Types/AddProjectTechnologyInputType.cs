using GraphQL.Types;
using MindworkingTest.Domain.Models;

namespace MindworkingTest.Application.Features.Projects.Types;

public class AddProjectTechnologyInputType : InputObjectGraphType<ProjectTechnology>
{
    public AddProjectTechnologyInputType()
    {
        Name = "AddProjectTechnologyInput";
        Field<NonNullGraphType<IntGraphType>>("technologyId");
        Field<NonNullGraphType<IntGraphType>>("projectId");
    }
}