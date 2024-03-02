using MindworkingTest.Application.Common.Extensions;
using MindworkingTest.Domain.Models;
using MindworkingTest.Repository.Tables;

namespace MindworkingTest.Application.Mappers;

public static class ProjectMapper
{
    /// <summary>
    /// Creates new instance of <see cref="Project"/> from <see cref="ProjectTable"/>
    /// </summary>
    /// <returns>New instance of <see cref="Project"/></returns>
    public static Project Map(ProjectTable table)
    => new()
    {
        Id = table.Id,
        Title = table.Title,
        Description = table.Description,
        StartDate = DateTime.Parse(table.StartDate),
        EndDate = table.EndDate.ParseDateOrNull()
    };
    /// <summary>
    /// Creates new instances of <see cref="Project"/> from enumarable <see cref="ProjectTable"/>
    /// </summary>
    /// <returns>Array of <see cref="Project"/></returns>
    public static IEnumerable<Project> Map(
        IEnumerable<ProjectTable> tableRows)
    => tableRows.Select(Map).ToArray();
}