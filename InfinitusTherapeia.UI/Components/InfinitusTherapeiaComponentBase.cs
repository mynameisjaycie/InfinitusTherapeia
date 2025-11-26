using Microsoft.AspNetCore.Components;

namespace InfinitusTherapeia.UI.Components;

public abstract class InfinitusTherapeiaComponentBase : ComponentBase
{
    [Inject] protected NavigationManager NavigationManager { get; private set; } = null!;
}