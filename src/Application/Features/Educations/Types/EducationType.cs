using GraphQL.Types;
using MindworkingTest.Domain.Models;

namespace MindworkingTest.Application.Features.Educations.Types;

public sealed class EducationType : ObjectGraphType<Education>
{
    public EducationType()
    {
        Name = nameof(Education);
        Description = "Projects worked on";
        Field(t => t.Id, nullable: false);
        Field(t => t.Name, nullable: false)
            .Description("Education name");
        Field(t => t.FieldOfStudy, nullable: false)
            .Description("Field of study");
        Field(t => t.StartDate, nullable: false)
            .Description("Education start date");
        Field(t => t.EndDate, nullable: true)
            .Description("Education end date");
    }
}