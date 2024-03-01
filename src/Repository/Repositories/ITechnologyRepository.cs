using MindworkingTest.Repository.Models;

namespace MindworkingTest.Repository.Repositories;

public interface ITechnologyRepository
{
    Task<TechnologyColumn?> CreateAsync(TechnologyColumn column);
    Task<TechnologyColumn?> GetAsync(int id);
}