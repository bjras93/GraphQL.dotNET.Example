using MindworkingTest.Domain.Models;
using MindworkingTest.Repository.Models;

namespace MindworkingTest.Application.Mappers;

public static class TechnologyMapper
{
    public static Technology Map(TechnologyColumn column)
    => new()
    {
        Id = column.Id,
        Name = column.Name
    };
}