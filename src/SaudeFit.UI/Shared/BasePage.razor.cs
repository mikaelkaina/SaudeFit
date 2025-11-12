using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace SaudeFit.UI.Shared
{
    public class BasePage : ComponentBase
    {
        [Inject] protected NavigationManager Nav { get; set; } = default!;
        [Inject] protected IJSRuntime JS { get; set; } = default!;

        public async Task GoBack(string fallbackRoute = "/dashboard")
        {
            try
            {
                var previousUri = Nav.Uri;
                await JS.InvokeVoidAsync("history.back");
                await Task.Delay(100);

                if (Nav.Uri == previousUri)
                {
                    Nav.NavigateTo(fallbackRoute, forceLoad: true);
                }
            }
            catch
            {
                Nav.NavigateTo(fallbackRoute, forceLoad: true);
            }
        }
    }
}
