using GraphQL;
using GraphQL.Types;
using MindworkingTest.Application.Features.Companies.Types;
using MindworkingTest.Application.Services;
using MindworkingTest.Domain.Models;

namespace MindworkingTest.Application.Features.Companies;

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