using MindworkingTest.Domain.Models;
using MindworkingTest.Repository.Tables;

namespace MindworkingTest.Application.Mappers;

public static class TechnologyMapper
{
    public static Technology Map(TechnologyTable table)
    => new()
    {
        Id = table.Id,
        Name = table.Name
    };
    public static IEnumerable<Technology> Map(IEnumerable<TechnologyTable> tableRows)
    => tableRows.Select(Map).ToArray();
}