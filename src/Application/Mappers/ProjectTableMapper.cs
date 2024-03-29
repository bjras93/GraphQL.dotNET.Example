using Domain.Models;
using Application.Common.Extensions;
using Repository.Tables;

namespace Application.Mappers;

public static class ProjectTableMapper
{
    /// <summary>
    /// Creates new instance of <see cref="ProjectTable"/> from <see cref="Project"/>
    /// </summary>
    /// <returns>New instance of <see cref="ProjectTable"/></returns>
    public static ProjectTable Map(Project project)
    => new()
    {
        Id = project.Id,
        Title = project.Title,
        Description = project.Description,
        StartDate = project.StartDate.ToString(),
        EndDate = project.EndDate.ToStringOrNull("O")
    };
    /// <summary>
    /// Creates new instances of <see cref="ProjectTable"/> from enumerable <see cref="Project"/>
    /// </summary>
    /// <returns>List of <see cref="ProjectTable"/></returns>
    public static IEnumerable<ProjectTable> Map(
        IEnumerable<Project> projects)
    => projects.Select(Map).ToList();
}