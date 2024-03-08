using MindworkingTest.Application.Mappers;
using MindworkingTest.Application.Unit.Faker;
using MindworkingTest.Domain.Enums;
using MindworkingTest.Repository.Tables;
using NSubstitute;
using NSubstitute.ReturnsExtensions;

namespace MindworkingTest.Application.Unit;

public sealed class CreateAsync
{
    private readonly Setup Setup = new();
    [Fact]
    public async void Repository_Should_Receive_1()
    {
        // Arrange
        var technologyId = 1;
        var technology = new TechnologyFaker().Generate();
        var skillId = 1;
        var skill = new SkillFaker(technologyId, SkillTypes.Technology).Generate();
        var skillTable = SkillTableMapper.Map(skill);

        skillTable.Id = skillId;

        Setup.TechnologyService
            .GetAsync(Arg.Is(technologyId))
            .Returns(technology);

        Setup.SkillRepository
            .CreateAsync(Arg.Any<SkillTable>())
            .Returns(skillTable);

        Setup.Reinitialize();

        // Act
        var created = await Setup.Service.CreateAsync(skill);
        // Assert
        Setup.SkillRepository.Received(1);
        Assert.NotNull(created);
    }
    [Fact]
    public async void Invalid_Reference_ReturnsNull()
    {
        // Arrange
        var technologyId = 1;
        var skillId = 1;
        var skill = new SkillFaker(technologyId, SkillTypes.Technology).Generate();
        var skillTable = SkillTableMapper.Map(skill);

        skillTable.Id = skillId;

        Setup.TechnologyService
            .GetAsync(Arg.Is(technologyId))
            .ReturnsNull();

        Setup.Reinitialize();

        // Act
        var created = await Setup.Service.CreateAsync(skill);
        // Assert
        Setup.SkillRepository.Received(0);
        Assert.Null(created);
    }
}