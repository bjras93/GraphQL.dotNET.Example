using MindworkingTest.Application.Common.Extensions;
using MindworkingTest.Domain.Models;
using MindworkingTest.Repository.Tables;

namespace MindworkingTest.Application.Mappers;

public static class ProjectMapper
{
    public static Project Map(ProjectTable table)
    => new()
    {
        Id = table.Id,
        Title = table.Title,
        Description = table.Description,
        StartDate = DateTime.Parse(table.StartDate),
        EndDate = table.EndDate.ParseDateOrNull()
    };
    public static IEnumerable<Project> Map(
        IEnumerable<ProjectTable> tableRows)
    => tableRows.Select(Map).ToArray();
}