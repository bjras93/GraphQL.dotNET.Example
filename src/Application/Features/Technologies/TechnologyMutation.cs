using GraphQL;
using GraphQL.Types;
using MindworkingTest.Application.Features.Technologies;
using MindworkingTest.Application.Services;
using MindworkingTest.Domain.Models;

namespace MindworkingTest.API.Features.Technologies;

public sealed class TechnologyMutation : ObjectGraphType
{
    private const string MutationName = "createTechnology";
    private const string InputName = "technology";

    public TechnologyMutation(ITechnologyService service)
    {
        Field<TechnologyType>(
            MutationName)
            .Argument<NonNullGraphType<TechnologyInputType>>(InputName)
            .ResolveAsync(async context =>
            {
                var input = context.GetArgument<Technology>(InputName);
                var technology = new Technology
                {
                    Name = input.Name
                };
                var createdTechnology = await service.CreateAsync(technology);
                return createdTechnology;
            });
    }
}