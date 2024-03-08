using GraphQL;
using GraphQL.Types;
using Application.Features.Technologies.Types;
using Application.Services;
using Domain.Models;

namespace Application.Features.Technologies;

public sealed class TechnologyMutation : ObjectGraphType
{
    public TechnologyMutation(ITechnologyService service)
    {
        Field<TechnologyType>(
            "createTechnology")
            .Argument<NonNullGraphType<TechnologyInputType>>("technology")
            .ResolveAsync(async context =>
            {
                var input = context.GetArgument<Technology>("technology");
                var technology = new Technology
                {
                    Name = input.Name
                };
                var createdTechnology = await service.CreateAsync(technology);
                return createdTechnology;
            });
    }
}