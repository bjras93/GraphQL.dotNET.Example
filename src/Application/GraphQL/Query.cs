using GraphQL.Types;
using MindworkingTest.Application.Features.Companies;
using MindworkingTest.Application.Features.CurriculumVitaes;
using MindworkingTest.Application.Features.Projects;
using MindworkingTest.Application.Features.Technologies;

namespace MindworkingTest.Application.GraphQL;

public sealed class Query : ObjectGraphType
{
    public Query()
    {
        Name = "Query";
        Description = "Queries for Curriculum Vitae data";
        Field<TechnologyQuery>("Technologies").Resolve(context => new { });
        Field<ProjectQuery>("Projects").Resolve(context => new { });
        Field<CompanyQuery>("Companies").Resolve(context => new { });
        Field<CurriculumVitaeQuery>("CurriculaVitarum").Resolve(context => new { });
    }
}