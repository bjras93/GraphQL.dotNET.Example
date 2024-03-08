using GraphQL.Types;
using Domain.Models;

namespace Application.Features.Companies.Types;

public class CompanyInputType : InputObjectGraphType<Company>
{
    public CompanyInputType()
    {
        Name = "CompanyInput";
        Field<NonNullGraphType<StringGraphType>>("Name");
        Field<NonNullGraphType<DateTimeGraphType>>("StartDate");
        Field<DateTimeGraphType>("EndDate");
    }
}