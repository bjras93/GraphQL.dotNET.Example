using MindworkingTest.Application.Common.Extensions;
using MindworkingTest.Domain.Models;
using MindworkingTest.Repository.Tables;

namespace MindworkingTest.Application.Mappers;

public static class EducationMapper
{
    /// <summary>
    /// Creates new instance of <see cref="Education"/> from <see cref="EducationTable"/>
    /// </summary>
    /// <returns>New instance of <see cref="Education"/></returns>
    public static Education Map(EducationTable table)
    => new()
    {
        Id = table.Id,
        Name = table.Name,
        FieldOfStudy = table.FieldOfStudy,
        StartDate = DateTime.Parse(table.StartDate),
        EndDate = table.EndDate.ParseDateOrNull(),
    };
    /// <summary>
    /// Creates new instances of <see cref="Education"/> from enumarable <see cref="EducationTable"/>
    /// </summary>
    /// <returns>Array of <see cref="Education"/></returns>
    public static IEnumerable<Education> Map(
        IEnumerable<EducationTable> tableRows)
    => tableRows.Select(Map).ToArray();
}