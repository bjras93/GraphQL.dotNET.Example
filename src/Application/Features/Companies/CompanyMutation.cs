using GraphQL;
using GraphQL.Types;
using Application.Features.Companies.Types;
using Application.Services;
using Domain.Models;

namespace Application.Features.Companies;

public sealed class CompanyMutation : ObjectGraphType
{
    public CompanyMutation(ICompanyService service)
    {
        Field<CompanyType>(
            "createCompany")
            .Argument<NonNullGraphType<CompanyInputType>>("company")
            .ResolveAsync(async context =>
            {
                var input = context.GetArgument<Company>("company");
                var company = new Company
                {
                    Name = input.Name,
                    StartDate = input.StartDate,
                    EndDate = input.EndDate
                };
                var createdCompany = await service.CreateAsync(company);
                return createdCompany;
            });
    }
}