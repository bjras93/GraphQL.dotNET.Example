using GraphQL.Types;
using MindworkingTest.Domain.Models;

namespace MindworkingTest.Application.Features.Educations.Types;

public class EducationInputType : InputObjectGraphType<Education>
{
    public EducationInputType()
    {
        Name = "EducationInput";
        Field<NonNullGraphType<StringGraphType>>("name");
        Field<NonNullGraphType<StringGraphType>>("fieldOfStudy");
        Field<NonNullGraphType<DateTimeGraphType>>("startDate");
        Field<DateTimeGraphType>("endDate");
    }
}