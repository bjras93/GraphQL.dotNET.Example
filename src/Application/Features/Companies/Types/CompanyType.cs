using GraphQL.Types;
using Domain.Models;

namespace Application.Features.Companies.Types;

public sealed class CompanyType : ObjectGraphType<Company>
{
    public CompanyType()
    {
        Name = nameof(Company);
        Description = "Companies worked for";
        Field(t => t.Id, nullable: false);
        Field(t => t.Name, nullable: false)
            .Description("Company name");
        Field(t => t.StartDate, nullable: false)
            .Description("Company start date");
        Field(t => t.EndDate, nullable: true)
            .Description("Company end date");
    }
}