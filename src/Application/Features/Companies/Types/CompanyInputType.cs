using GraphQL.Types;
using MindworkingTest.Domain.Models;

namespace MindworkingTest.Application.Features.Companies.Types;

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