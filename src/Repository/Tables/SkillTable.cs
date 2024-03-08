using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Tables;

[Table("skills")]
public sealed class SkillTable
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    [Column("proficiency_level")]
    public int ProficiencyLevel { get; set; }
    [Column("experience_years")]
    public decimal ExperienceYears { get; set; }
    [Column("reference_id")]
    public int ReferenceId { get; set; }
    [Column("reference_type")]
    public int ReferenceType { get; set; }
}