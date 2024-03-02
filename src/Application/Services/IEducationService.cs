using MindworkingTest.Domain.Models;

namespace MindworkingTest.Application.Services;

public interface IEducationService
{
    Task<Education?> CreateAsync(Education education);
    Task<IEnumerable<Education>> GetAsync();
}