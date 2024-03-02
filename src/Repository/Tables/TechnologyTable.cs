using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MindworkingTest.Repository.Tables;

[Table("technologies")]
public sealed class TechnologyTable
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    [Column("name")]
    public required string Name { get; set; }
    public static TechnologyTable Create(TechnologyTable technology)
    => new()
    {
        Id = technology.Id,
        Name = technology.Name
    };
}