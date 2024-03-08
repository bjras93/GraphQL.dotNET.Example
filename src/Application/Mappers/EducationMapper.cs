using Application.Common.Extensions;
using Domain.Models;
using Repository.Tables;

namespace Application.Mappers;

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
    /// <returns>List of <see cref="Education"/></returns>
    public static IEnumerable<Education> Map(
        IEnumerable<EducationTable> tableRows)
    => tableRows.Select(Map).ToList();
}