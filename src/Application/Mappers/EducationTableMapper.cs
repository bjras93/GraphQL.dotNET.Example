using Application.Common.Extensions;
using Domain.Models;
using Repository.Tables;

namespace Application.Mappers;

public static class EducationTableMapper
{
    /// <summary>
    /// Creates new instance of <see cref="EducationTable"/> from <see cref="Education"/>
    /// </summary>
    /// <returns>New instance of <see cref="EducationTable"/></returns>
    public static EducationTable Map(Education education)
    => new()
    {
        Name = education.Name,
        FieldOfStudy = education.FieldOfStudy,
        StartDate = education.StartDate.ToString("O"),
        EndDate = education.EndDate.ToStringOrNull("O"),
    };
    /// <summary>
    /// Creates new instances of <see cref="EducationTable"/> from enumerable <see cref="Education"/>
    /// </summary>
    /// <returns>List of <see cref="EducationTable"/></returns>
    public static IEnumerable<EducationTable> Map(
        IEnumerable<Education> educations)
    => educations.Select(Map).ToList();
}