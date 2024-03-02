using GraphQL.Types;
using MindworkingTest.Application.Features.Companies.Types;
using MindworkingTest.Application.Features.Educations.Types;
using MindworkingTest.Application.Features.Projects.Types;
using MindworkingTest.Domain.Models;

namespace MindworkingTest.Application.Features.CurriculumVitarum.Types;

public sealed class CurriculumVitaeType : ObjectGraphType<CurriculumVitae>
{
    public CurriculumVitaeType()
    {
        Name = nameof(CurriculumVitae);
        Description = "Curriculum vitae";

        Field<ListGraphType<CompanyType>>("companies")
            .Description("Companies worked for")
            .Resolve(context =>
                context.Source.Companies
            );
        Field<ListGraphType<ProjectType>>("projects")
            .Description("Projects worked on")
            .Resolve(context =>
                context.Source.Projects
            );
        Field<ListGraphType<SkillType>>("skills")
            .Description("Acquired skills")
            .Resolve(context =>
                context.Source.Skills
            );
        Field<ListGraphType<EducationType>>("educations")
            .Description("Educations")
            .Resolve(context =>
                context.Source.Educations
            );
    }
}