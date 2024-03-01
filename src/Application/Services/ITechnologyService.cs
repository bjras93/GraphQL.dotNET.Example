using MindworkingTest.Domain.Models;

namespace MindworkingTest.Application.Services;

public interface ITechnologyService
{
    Task<Technology?> CreateAsync(Technology technology);
    Task<Technology?> GetAsync(int id);
}