public sealed class Recipe
{
    public required int Id { get; init; }
    public required string Name { get; init; }
    public required string Category { get; init; }
    public required string Description { get; init; }
    public required string Preview { get; init; }
    public required string Code { get; init; }
    public required string Accent { get; init; }
    public string? Css { get; init; }
    public string? JavaScript { get; init; }
}