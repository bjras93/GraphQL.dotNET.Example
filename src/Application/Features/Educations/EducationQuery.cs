using GraphQL.Types;
using MindworkingTest.Application.Features.Educations.Types;
using MindworkingTest.Application.Services;

namespace MindworkingTest.Application.Features.Educations;

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