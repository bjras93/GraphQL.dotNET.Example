using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Tables;

[Table("project_technologies")]
public sealed class ProjectTechnologyTable
{
    [Column("id")]
    [Key]
    public int Id { get; set; }
    [Column("technology_id")]
    public int TechnologyId { get; set; }
    [Column("project_id")]
    public int ProjectId { get; set; }
}