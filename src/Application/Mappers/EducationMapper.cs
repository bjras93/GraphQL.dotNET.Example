using MindworkingTest.Application.Common.Extensions;
using MindworkingTest.Domain.Models;
using MindworkingTest.Repository.Tables;

namespace MindworkingTest.Application.Mappers;

public static class EducationMapper
{
    public static Education Map(EducationTable table)
    => new()
    {
        Id = table.Id,
        Name = table.Name,
        FieldOfStudy = table.FieldOfStudy,
        StartDate = DateTime.Parse(table.StartDate),
        EndDate = table.EndDate.ParseDateOrNull(),
    };
    public static IEnumerable<Education> Map(
        IEnumerable<EducationTable> tableRows)
    => tableRows.Select(Map).ToArray();
}