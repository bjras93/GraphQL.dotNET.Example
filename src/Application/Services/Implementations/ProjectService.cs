using MindworkingTest.Application.Mappers;
using MindworkingTest.Domain.Models;
using MindworkingTest.Repository.Repositories;
using MindworkingTest.Repository.Tables;

namespace MindworkingTest.Application.Services.Implementations;

public sealed class ProjectService : IProjectService
{

    private readonly IProjectRepository Repository;
    private readonly ITechnologyRepository TechnologyRepository;
    private readonly IProjectTechnologyRepository ProjectTechnologyRepository;
    public ProjectService(
        IProjectRepository repository,
        ITechnologyRepository technologyRepository,
        IProjectTechnologyRepository projectTechnologyRepository
    )
    {
        Repository = repository;
        TechnologyRepository = technologyRepository;
        ProjectTechnologyRepository = projectTechnologyRepository;
    }

    public async Task<Project?> CreateAsync(Project project)
    {
        var row = ProjectTableMapper.Map(project);


        var newProject = await Repository.CreateAsync(row);

        if (newProject == null)
            return null;

        var mappedProject = ProjectMapper.Map(newProject);

        return mappedProject;
    }
    public async Task<ProjectTechnology?> AddTechnologyAsync(int id, int technologyId)
    {
        var technology = await TechnologyRepository.GetAsync(technologyId);

        if (technology == null)
            return null;

        var projectTechnology = new ProjectTechnologyTable
        {
            ProjectId = id,
            TechnologyId = technology.Id
        };

        var projectTechnologyTable = await ProjectTechnologyRepository.CreateAsync(projectTechnology);

        if (projectTechnologyTable == null)
            return null;

        var mappedProjectTechnology = ProjectTechnologyMapper.Map(projectTechnologyTable);

        return mappedProjectTechnology;
    }

    public async Task<IEnumerable<Project>> GetAsync()
    {
        var rows = await Repository.GetAsync();

        var technologyIds = rows
            .SelectMany(rows => rows.ProjectTechnologies.Select(p => p.TechnologyId))
            .ToArray();
        var technologies = await TechnologyRepository.GetAsync(technologyIds);

        var projects = rows.Select(r =>
        {
            var project = ProjectMapper.Map(r);
            // Map technologies from the ProjectTechnologies
            var tech = technologies
                // Filter on Technology Id
                .Where(t => r.ProjectTechnologies.Any(pt => pt.TechnologyId == t.Id))
                .Select(t => TechnologyMapper.Map(t));

            project.Technologies = tech;
            return project;
        });

        return projects.ToArray();
    }
}