using MindworkingTest.Domain.Models;

namespace MindworkingTest.Application.Services;

public interface ICompanyService
{
    Task<Company?> CreateAsync(Company company);
    Task<IEnumerable<Company>> GetAsync();
    Task<Company?> GetAsync(int id);

}