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
        var table = TechnologyTableMapper.Map(technology);
        var newTechnology = await Repository.CreateAsync(table);

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

    public async Task<IEnumerable<Technology>> GetAsync()
    {
        var rows = await Repository.GetAsync();

        var technologies = TechnologyMapper.Map(rows);
        return technologies;
    }

    public async Task<IEnumerable<Technology>> GetByNameAsync(string name)
    {
        var rows = await Repository.GetByAsync(t => t.Name == name);

        var technologies = TechnologyMapper.Map(rows);
        return technologies;
    }
}