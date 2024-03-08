using GraphQL.Types;
using Domain.Models;

namespace Application.Features.Projects.Types;

public class ProjectInputType : InputObjectGraphType<Project>
{
    public ProjectInputType()
    {
        Name = "ProjectInput";
        Field<NonNullGraphType<StringGraphType>>(nameof(Project.Title));
        Field<NonNullGraphType<StringGraphType>>(nameof(Project.Description));
        Field<NonNullGraphType<DateTimeGraphType>>(nameof(Project.StartDate));
        Field<DateTimeGraphType>(nameof(Project.EndDate));
    }
}