namespace Domain.Models;

public sealed class CurriculumVitae
{
    public required IEnumerable<Skill> Skills { get; set; }
    public required IEnumerable<Company> Companies { get; set; }
    public required IEnumerable<Project> Projects { get; set; }
    public required IEnumerable<Education> Educations { get; set; }
}