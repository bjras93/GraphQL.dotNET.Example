using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MindworkingTest.Repository.Tables;

[Table("educations")]
public sealed class EducationTable
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    [Column("name")]
    public required string Name { get; set; }
    [Column("field_of_study")]
    public required string FieldOfStudy { get; set; }
    [Column("start_date")]
    public required string StartDate { get; set; }
    [Column("end_date")]
    public string? EndDate { get; set; }
}