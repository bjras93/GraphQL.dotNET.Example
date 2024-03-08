using GraphQL.Types;
using Application.Features.Educations.Types;
using Application.Services;

namespace Application.Features.Educations;

public sealed class EducationQuery : ObjectGraphType
{
    public EducationQuery(
        IEducationService service)
    {
        Field<ListGraphType<EducationType>>("educations")
        .ResolveAsync(async context =>
        {
            var educations = await service.GetAsync();
            return educations;
        });
    }
}