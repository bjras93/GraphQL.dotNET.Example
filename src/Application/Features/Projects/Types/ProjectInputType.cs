using GraphQL.Types;
using Domain.Models;

namespace Application.Features.Projects.Types;

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