using MindworkingTest.Domain.Models;
using MindworkingTest.Repository.Tables;

namespace MindworkingTest.Application.Mappers;

public static class ProjectTechnologyMapper
{
    public static ProjectTechnology Map(ProjectTechnologyTable table)
    => new()
    {
        Id = table.Id,
        ProjectId = table.ProjectId,
        TechnologyId = table.ProjectId
    };
    public static IEnumerable<ProjectTechnology> Map(IEnumerable<ProjectTechnologyTable> tableRows)
    => tableRows.Select(Map).ToArray();
}