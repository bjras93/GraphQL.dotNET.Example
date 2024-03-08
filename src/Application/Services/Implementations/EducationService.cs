using Application.Mappers;
using Domain.Models;
using Repository.Repositories;

namespace Application.Services.Implementations;

public sealed class EducationService(
    IEducationRepository repository
    ) : IEducationService
{
    private readonly IEducationRepository Repository = repository;

    public async Task<Education?> CreateAsync(
        Education education)
    {
        var row = EducationTableMapper.Map(education);
        var createdRow = await Repository.CreateAsync(row);

        if (createdRow == null)
            return null;

        var newEducation = EducationMapper.Map(createdRow);

        return newEducation;
    }

    public async Task<IEnumerable<Education>> GetAsync()
    {
        var rows = await Repository.GetAsync();

        var educations = EducationMapper.Map(rows);

        return educations;
    }
}
