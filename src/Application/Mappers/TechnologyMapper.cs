using Domain.Models;
using Repository.Tables;

namespace Application.Mappers;

public static class TechnologyMapper
{
    /// <summary>
    /// Creates new instance of <see cref="Technology"/> from <see cref="TechnologyTable"/>
    /// </summary>
    /// <returns>New instance of <see cref="Technology"/></returns>
    public static Technology Map(TechnologyTable table)
    => new()
    {
        Id = table.Id,
        Name = table.Name
    };
    /// <summary>
    /// Creates new instances of <see cref="Technology"/> from enumerable <see cref="TechnologyTable"/>
    /// </summary>
    /// <returns>List of <see cref="Technology"/></returns>
    public static IEnumerable<Technology> Map(
        IEnumerable<TechnologyTable> tableRows)
    => tableRows.Select(Map).ToList();
}