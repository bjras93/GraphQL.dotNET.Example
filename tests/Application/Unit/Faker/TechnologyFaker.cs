using Bogus;
using Domain.Models;

namespace Application.Unit.Faker;

public sealed class TechnologyFaker : Faker<Technology>
{
    public TechnologyFaker()
    {
        RuleFor(t => t.Name, f => f.Hacker.Verb());
    }
}