using GraphQL.Types;
using Application.Features.Companies.Types;
using Application.Features.Educations.Types;
using Application.Features.Projects.Types;
using Domain.Models;

namespace Application.Features.CurriculumVitarum.Types;

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