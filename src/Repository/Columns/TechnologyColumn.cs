using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MindworkingTest.Repository.Models;

[Table("technology")]
public sealed class TechnologyColumn
{
    [Key]
    [JsonIgnore]
    [Column("id")]
    public int Id { get; set; }
    [Column("name")]
    public required string Name { get; set; }
}