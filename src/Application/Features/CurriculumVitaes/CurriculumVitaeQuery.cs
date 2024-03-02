using GraphQL.Types;
using MindworkingTest.Application.Features.CurriculumVitaes.Types;
using MindworkingTest.Application.Services;
using MindworkingTest.Domain.Models;

namespace MindworkingTest.Application.Features.CurriculumVitaes;

public sealed class CurriculumVitaeQuery : ObjectGraphType
{
    public CurriculumVitaeQuery(
        IProjectService projectService,
        ICompanyService companyService,
        ITechnologyService technologyService)
    {
        Description = "Queries curriculum vitae";
        Field<CurriculumVitaeType>("curriculumVitae")
        .ResolveAsync(async context =>
        {
            var projects = await projectService.GetAsync();
            var companies = await companyService.GetAsync();
            var technologies = await technologyService.GetAsync();

            var skills = technologies.Select(t => new Skill { Name = t.Name });
            var curriculumVitae = new CurriculumVitae
            {
                Companies = companies,
                Projects = projects,
                Skills = skills
            };
            return curriculumVitae;
        });
    }
}