using MindworkingTest.Domain.Models;
using MindworkingTest.Repository.Tables;

namespace MindworkingTest.Application.Mappers;

public static class TechnologyTableMapper
{
    public static TechnologyTable Map(Technology technology)
    => new()
    {
        Id = technology.Id,
        Name = technology.Name
    };
}