using Microsoft.AspNetCore.Components;

namespace InfinitusTherapeia.UI.Components;

public partial class InfinitusTherapeiaCardComponent : InfinitusTherapeiaComponentBase
{

    [Parameter] public string CardHeaderText { get; set; } = string.Empty;
    
    [Parameter] public RenderFragment? CardContentFragment { get; set; }
    
    [Parameter] public RenderFragment? CardActionsFragment { get; set; }

    private const string CardHeaderStyle = "background-color: var(--mud-palette-tertiary); color: var(--mud-palette-secondary)";
}