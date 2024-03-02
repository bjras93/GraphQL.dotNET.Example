using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MindworkingTest.Repository.Tables;

[Table("companies")]
public sealed class CompanyTable
{
    [Column("id")]
    [Key]
    public int Id { get; set; }
    [Column("name")]
    public required string Name { get; set; }
    [Column("start_date")]
    public required string StartDate { get; set; }
    [Column("end_date")]
    public string? EndDate { get; set; }
}