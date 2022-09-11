// ReSharper disable UnusedAutoPropertyAccessor.Global
namespace PropellerService;

public record Factor
{

    public string Name { get; init; } = default!;
    public string Description { get; init; } = default!;
    public int Number { get; init; }
}
