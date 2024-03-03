using MindworkingTest.Domain.Models;
using MindworkingTest.Repository.Tables;

namespace MindworkingTest.Application.Mappers;

public static class ProjectTechnologyMapper
{
    /// <summary>
    /// Creates new instance of <see cref="ProjectTechnology"/> from <see cref="ProjectTechnologyTable"/>
    /// </summary>
    /// <returns>New instance of <see cref="ProjectTechnology"/></returns>
    public static ProjectTechnology Map(ProjectTechnologyTable table)
    => new()
    {
        Id = table.Id,
        ProjectId = table.ProjectId,
        TechnologyId = table.ProjectId
    };
    /// <summary>
    /// Creates new instances of <see cref="ProjectTechnology"/> from enumerable <see cref="ProjectTechnology"/>
    /// </summary>
    /// <returns>List of <see cref="ProjectTechnology"/></returns>
    public static IEnumerable<ProjectTechnology> Map(
        IEnumerable<ProjectTechnologyTable> tableRows)
    => tableRows.Select(Map).ToList();
}