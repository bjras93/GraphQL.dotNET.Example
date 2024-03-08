namespace Domain.Models;

public sealed class Education
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string FieldOfStudy { get; set; }
    public required DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}