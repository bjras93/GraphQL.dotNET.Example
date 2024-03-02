using GraphQL.Types;
using MindworkingTest.Application.Features.Companies;
using MindworkingTest.Application.Features.CurriculumVitarum;
using MindworkingTest.Application.Features.Educations;
using MindworkingTest.Application.Features.Projects;
using MindworkingTest.Application.Features.Technologies;

namespace MindworkingTest.Application.GraphQL;

public sealed class Query : ObjectGraphType
{
    public Query()
    {
        Name = "Query";
        Description = "Queries for Curriculum Vitae data";
        Field<TechnologyQuery>("Technologies")
            .Description("Queries for technologies")
            .Resolve(context => new { });
        Field<ProjectQuery>("Projects")
            .Description("Queries for projects")
            .Resolve(context => new { });
        Field<CompanyQuery>("Companies")
            .Description("Queries for companies")
            .Resolve(context => new { });
        Field<CurriculumVitaeQuery>("CurriculumVitarum")
            .Description("Queries for curriculum vitarum")
            .Resolve(context => new { });
        Field<EducationQuery>("Educations")
            .Description("Queries for educations")
            .Resolve(context => new { });
    }
}