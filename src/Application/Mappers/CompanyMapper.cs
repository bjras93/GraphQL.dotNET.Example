using MindworkingTest.Application.Common.Extensions;
using MindworkingTest.Domain.Models;
using MindworkingTest.Repository.Tables;

public static class CompanyMapper
{
    public static Company Map(CompanyTable table)
    => new()
    {
        Id = table.Id,
        Name = table.Name,
        StartDate = DateTime.Parse(table.StartDate),
        EndDate = table.EndDate.ParseDateOrNull()
    };
    public static IEnumerable<Company> Map(
        IEnumerable<CompanyTable> tableRows)
    => tableRows.Select(Map).ToArray();
}