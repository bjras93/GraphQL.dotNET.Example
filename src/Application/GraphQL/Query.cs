using GraphQL.Types;
using Application.Features.Companies;
using Application.Features.CurriculumVitarum;
using Application.Features.Educations;
using Application.Features.Projects;
using Application.Features.Technologies;

namespace Application.GraphQL;

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