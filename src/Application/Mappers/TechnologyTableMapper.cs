using Domain.Models;
using Repository.Tables;

namespace Application.Mappers;

public static class TechnologyTableMapper
{
    /// <summary>
    /// Creates new instance of <see cref="TechnologyTable"/> from <see cref="Technology"/>
    /// </summary>
    /// <returns>New instance of <see cref="TechnologyTable"/></returns>
    public static TechnologyTable Map(Technology technology)
    => new()
    {
        Id = technology.Id,
        Name = technology.Name
    };
}