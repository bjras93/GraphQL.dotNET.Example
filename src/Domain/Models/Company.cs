namespace Domain.Models;

public sealed class Company
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required DateTime StartDate { get; set; }
    public required DateTime? EndDate { get; set; }
}