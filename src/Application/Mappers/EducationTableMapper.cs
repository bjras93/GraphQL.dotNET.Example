using MindworkingTest.Application.Common.Extensions;
using MindworkingTest.Domain.Models;
using MindworkingTest.Repository.Tables;

namespace MindworkingTest.Application.Mappers;

public static class EducationTableMapper
{
    public static EducationTable Map(Education education)
    => new()
    {
        Name = education.Name,
        FieldOfStudy = education.FieldOfStudy,
        StartDate = education.StartDate.ToString("O"),
        EndDate = education.EndDate.ToStringOrNull("O"),
    };
    public static IEnumerable<EducationTable> Map(
        IEnumerable<Education> educations)
    => educations.Select(Map).ToArray();
}