using GraphQL;
using GraphQL.Types;
using Application.Features.Companies.Types;
using Application.Services;

namespace Application.Features.Companies;

public sealed class CompanyQuery : ObjectGraphType
{
    public CompanyQuery(ICompanyService service)
    {
        Field<ListGraphType<CompanyType>>("companies")
        .Description("Gets all companies")
        .ResolveAsync(async context =>
        {
            var projects = await service.GetAsync();
            return projects;
        });
        Field<CompanyType>("company")
        .Description("Gets company by Id")
        .Argument<int>("id")
        .ResolveAsync(async context =>
        {
            var id = context.GetArgument<int>("id");
            var projects = await service.GetAsync(id);
            return projects;
        });
    }
}