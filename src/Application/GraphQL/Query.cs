using GraphQL.Types;
using MindworkingTest.Application.Features.Companies;
using MindworkingTest.Application.Features.Projects;
using MindworkingTest.Application.Features.Technologies;

namespace MindworkingTest.Application.GraphQL;

public sealed class Query : ObjectGraphType
{
    public Query()
    {
        Name = "Query";
        Field<TechnologyQuery>("technology").Resolve(context => new { });
        Field<ProjectQuery>("project").Resolve(context => new { });
        Field<CompanyQuery>("company").Resolve(context => new { });
    }
}