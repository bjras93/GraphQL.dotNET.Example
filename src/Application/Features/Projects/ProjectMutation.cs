using GraphQL;
using GraphQL.Types;
using MindworkingTest.Application.Features.Projects.Types;
using MindworkingTest.Application.Services;
using MindworkingTest.Domain.Models;

namespace MindworkingTest.API.Features.Technologies;

public sealed class ProjectMutation : ObjectGraphType
{
    public ProjectMutation(
        IProjectService service)
    {
        Field<ProjectType>(
            "createProject")
            .Argument<NonNullGraphType<ProjectInputType>>("project")
            .ResolveAsync(async context =>
            {
                var input = context.GetArgument<Project>("project");
                var project = new Project
                {
                    Title = input.Title,
                    Description = input.Description,
                    StartDate = input.StartDate,
                    EndDate = input.EndDate,
                    Technologies = input.Technologies
                };
                var createdProject = await service.CreateAsync(project);

                return createdProject;
            });
        Field<ProjectTechnologyType>(
            "addProjectTechnology")
            .Argument<NonNullGraphType<AddProjectTechnologyInputType>>("projectTechnology")
            .ResolveAsync(async context =>
            {
                var input = context.GetArgument<ProjectTechnology>("projectTechnology");

                var createdProject = await service.AddTechnologyAsync(input.ProjectId, input.TechnologyId);

                return createdProject;
            });
    }
}