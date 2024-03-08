using GraphQL.Types;
using Application.Features.CurriculumVitarum.Types;
using Application.Services;
using Domain.Enums;
using Domain.Models;

namespace Application.Features.CurriculumVitarum;

public sealed class CurriculumVitaeQuery : ObjectGraphType
{
    public CurriculumVitaeQuery(
        IProjectService projectService,
        ICompanyService companyService,
        ISkillService skillService,
        IEducationService educationService)
    {
        Field<CurriculumVitaeType>("curriculumVitae")
        .Description("Queries curriculum vitae")
        .ResolveAsync(async context =>
        {
            var projects = await projectService.GetAsync();
            var companies = await companyService.GetAsync();
            var skills = await skillService.GetAsync([SkillTypes.Technology]);
            var educations = await educationService.GetAsync();

            var curriculumVitae = new CurriculumVitae
            {
                Companies = companies,
                Projects = projects,
                Skills = skills,
                Educations = educations
            };
            return curriculumVitae;
        });
    }
}