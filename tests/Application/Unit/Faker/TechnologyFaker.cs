using Bogus;
using MindworkingTest.Domain.Models;

namespace MindworkingTest.Application.Unit.Faker;

public sealed class TechnologyFaker : Faker<Technology>
{
    public TechnologyFaker()
    {
        RuleFor(t => t.Name, f => f.Hacker.Verb());
    }
}