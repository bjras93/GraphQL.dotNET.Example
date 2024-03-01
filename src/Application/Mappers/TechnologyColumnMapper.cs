using MindworkingTest.Domain.Models;
using MindworkingTest.Repository.Models;

namespace MindworkingTest.Application.Mappers;

public static class TechnologyColumnMapper
{
    public static TechnologyColumn Map(Technology technology)
    => new()
    {
        Id = technology.Id,
        Name = technology.Name
    };
}