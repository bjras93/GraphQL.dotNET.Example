namespace Repository.Common.Options;

public sealed class DatabaseOptions
{
    public const string Name = "DatabaseOptions";
    public required Dictionary<string, string> ConnectionStrings { get; set; }
}