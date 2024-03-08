using GraphQL.Types;
using Application.Features.Technologies.Types;
using Domain.Models;

namespace Application.Features.Projects.Types;

public sealed class ProjectType : ObjectGraphType<Project>
{
    public ProjectType()
    {
        Name = nameof(Project);
        Description = "Projects worked on";
        Field(t => t.Id, nullable: false);
        Field(t => t.Title, nullable: false)
            .Description("Project title");
        Field(t => t.Description, nullable: false)
            .Description("Project description");
        Field(t => t.StartDate, nullable: false)
            .Description("Project start date");
        Field(t => t.EndDate, nullable: true)
            .Description("Project end date");
        Field<ListGraphType<TechnologyType>>("technologies")
            .Description("Technologies used on project")
            .Resolve(context =>
                context.Source.Technologies
            );
    }
}