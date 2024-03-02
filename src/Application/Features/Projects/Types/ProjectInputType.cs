using GraphQL.Types;
using MindworkingTest.Domain.Models;

namespace MindworkingTest.Application.Features.Projects.Types;

public class ProjectInputType : InputObjectGraphType<Project>
{
    public ProjectInputType()
    {
        Name = "ProjectInput";
        Field<NonNullGraphType<StringGraphType>>("title");
        Field<NonNullGraphType<StringGraphType>>("description");
        Field<NonNullGraphType<DateTimeGraphType>>("startDate");
        Field<DateTimeGraphType>("endDate");
    }
}