using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MindworkingTest.Repository.Tables;

[Table("projects")]
public sealed class ProjectTable
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    [Column("title")]
    public required string Title { get; set; }
    [Column("description")]
    public required string Description { get; set; }
    [Column("start_date")]
    public required string StartDate { get; set; }
    [Column("end_date")]
    public required string? EndDate { get; set; }

    #region Navigation properties
    public IList<ProjectTechnologyTable> ProjectTechnologies { get; set; } = [];
    #endregion
    public static ProjectTable Create(ProjectTable project)
    => new()
    {
        Id = project.Id,
        Title = project.Title,
        Description = project.Description,
        StartDate = project.StartDate,
        EndDate = project.EndDate
    };

}