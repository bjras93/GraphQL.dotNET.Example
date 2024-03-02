using MindworkingTest.Domain.Models;
using MindworkingTest.Application.Common.Extensions;
using MindworkingTest.Repository.Tables;

namespace MindworkingTest.Application.Mappers;

public static class ProjectTableMapper
{
    public static ProjectTable Map(Project project)
    => new()
    {
        Id = project.Id,
        Title = project.Title,
        Description = project.Description,
        StartDate = project.StartDate.ToString(),
        EndDate = project.EndDate.ToStringOrNull("o")
    };
    public static IEnumerable<ProjectTable> Map(
        IEnumerable<Project> projects)
    => projects.Select(Map).ToArray();
}