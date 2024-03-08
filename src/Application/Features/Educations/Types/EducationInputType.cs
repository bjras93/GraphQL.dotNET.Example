using GraphQL.Types;
using Domain.Models;

namespace Application.Features.Educations.Types;

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