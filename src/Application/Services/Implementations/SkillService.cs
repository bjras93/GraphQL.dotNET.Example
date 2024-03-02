using MindworkingTest.Application.Mappers;
using MindworkingTest.Domain.Enums;
using MindworkingTest.Domain.Models;
using MindworkingTest.Repository.Repositories;

namespace MindworkingTest.Application.Services.Implementations;

public sealed class SkillService : ISkillService
{
    private readonly ISkillRepository Repository;
    private readonly ITechnologyService TechnologyService;
    public SkillService(
        ISkillRepository repository,
        ITechnologyService technologyService
    )
    {
        Repository = repository;
        TechnologyService = technologyService;
    }
    public async Task<Skill?> CreateAsync(Skill skill)
    {
        var validReference = await ValidateReferenceAsync(skill);

        if (!validReference)
            return null;

        var row = SkillTableMapper.Map(skill);
        var createdSkill = await Repository.CreateAsync(row);

        if (createdSkill == null)
            return null;

        var newSkill = SkillMapper.Map(createdSkill);

        return newSkill;
    }


    public async Task<IEnumerable<Skill>> GetAsync(
        IEnumerable<SkillTypes> skillTypes
    )
    {
        var rows = await Repository.GetAsync();
        var skills = SkillMapper.Map(rows);
        foreach (var skillName in skillTypes)
        {
            await AddSkillsAsync(skillName, skills);
        }
        return skills;
    }

    public async Task AddSkillsAsync(SkillTypes skillType, IEnumerable<Skill> skills)
    {
        switch (skillType)
        {
            case SkillTypes.Technology:
                await AddTechnologyAsync(skills);
                break;
        }
    }
    public async Task<bool> ValidateReferenceAsync(Skill skill)
    {
        return skill.ReferenceType switch
        {
            SkillTypes.Technology => await ValidateTechnologyAsync(skill.ReferenceId),
            _ => false,
        };
    }
    public async Task<bool> ValidateTechnologyAsync(int id)
    {
        return (await TechnologyService.GetAsync(id)) != null;
    }
    public async Task<IEnumerable<Skill>> AddTechnologyAsync(IEnumerable<Skill> skills)
    {
        var technologySkills = skills
            .Where(s => s.ReferenceType == SkillTypes.Technology)
            .Select(s => s.ReferenceId);
        var technologies = await TechnologyService.GetAsync(technologySkills);

        foreach (var skill in skills.Where(s => s.ReferenceType == SkillTypes.Technology))
        {
            var technology = technologies.FirstOrDefault(t => t.Id == skill.ReferenceId);

            if (technology == null)
                continue;

            skill.Name = technology.Name;
        }

        return skills;
    }
}