using MindworkingTest.Application.Common.Extensions;
using MindworkingTest.Domain.Models;
using MindworkingTest.Repository.Tables;

namespace MindworkingTest.Application.Mappers;

public static class CompanyMapper
{
    /// <summary>
    /// Creates new instance of <see cref="Company"/> from <see cref="CompanyTable"/>
    /// </summary>
    /// <returns>New instance of <see cref="Company"/></returns>
    public static Company Map(CompanyTable table)
    => new()
    {
        Id = table.Id,
        Name = table.Name,
        StartDate = DateTime.Parse(table.StartDate),
        EndDate = table.EndDate.ParseDateOrNull()
    };
    /// <summary>
    /// Creates new instances of <see cref="Company"/> from enumarable <see cref="CompanyTable"/>
    /// </summary>
    /// <returns>List of <see cref="Company"/></returns>
    public static IEnumerable<Company> Map(
        IEnumerable<CompanyTable> tableRows)
    => tableRows.Select(Map).ToList();
}