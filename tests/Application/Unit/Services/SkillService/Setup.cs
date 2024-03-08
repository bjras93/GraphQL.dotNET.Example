using Application.Services;
using Application.Services.Implementations;
using Repository.Repositories;
using Shared;
using NSubstitute;

namespace Application.Unit;

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