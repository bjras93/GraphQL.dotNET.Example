using MindworkingTest.Application.Mappers;
using MindworkingTest.Domain.Models;
using MindworkingTest.Repository.Repositories;

namespace MindworkingTest.Application.Services.Implementations;

public sealed class TechnologyService : ITechnologyService
{
    public ITechnologyRepository Repository;
    public TechnologyService(
        ITechnologyRepository repository)
    {
        Repository = repository;
    }
    public async Task<Technology?> CreateAsync(Technology technology)
    {
        var column = TechnologyColumnMapper.Map(technology);
        var newTechnology = await Repository.CreateAsync(column);

        if (newTechnology == null)
            return null;

        var mappedTechnology = TechnologyMapper.Map(newTechnology);

        return mappedTechnology;
    }

    public async Task<Technology?> GetAsync(int id)
    {
        var technology = await Repository.GetAsync(id);

        if (technology == null)
            return null;

        var mappedTechnology = TechnologyMapper.Map(technology);

        return mappedTechnology;
    }
}