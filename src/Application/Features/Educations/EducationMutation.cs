using GraphQL;
using GraphQL.Types;
using MindworkingTest.Application.Features.Educations.Types;
using MindworkingTest.Application.Services;
using MindworkingTest.Domain.Models;

namespace MindworkingTest.Application.Features.Educations;

public sealed class EducationMutation : ObjectGraphType
{
    public EducationMutation(
        IEducationService service)
    {
        Field<EducationType>(
            "createEducation")
            .Argument<NonNullGraphType<EducationInputType>>("education")
            .ResolveAsync(async context =>
            {
                var input = context.GetArgument<Education>("education");
                var project = new Education
                {
                    Name = input.Name,
                    FieldOfStudy = input.FieldOfStudy,
                    StartDate = input.StartDate,
                    EndDate = input.EndDate
                };
                var createdProject = await service.CreateAsync(project);

                return createdProject;
            });
    }
}