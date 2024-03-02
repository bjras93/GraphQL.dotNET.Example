using MindworkingTest.Application.Services;
using MindworkingTest.Application.Services.Implementations;
using MindworkingTest.Repository.Repositories;
using MindworkingTest.Shared;
using NSubstitute;

namespace MindworkingTest.Application.Unit;

public sealed class Setup : ISetup<SkillService>
{
    public SkillService Service { get; set; }
    public ISkillRepository SkillRepository;
    public ITechnologyService TechnologyService;
    public Setup()
    {
        SkillRepository = Substitute.For<ISkillRepository>();
        TechnologyService = Substitute.For<ITechnologyService>();
        Service = new SkillService(SkillRepository, TechnologyService);
    }


    public SkillService Reinitialize()
    => new(SkillRepository, TechnologyService);
}