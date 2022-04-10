using Microsoft.AspNetCore.Components;

namespace LinkBakery.Web.Cms.Components.Layout
{
    public class NavMenuComponentBase : ComponentBase
    {
        private bool _collapseNavMenu = true;

        protected string? navMenuCssClass => _collapseNavMenu ? "collapse" : null;

        protected void ToggleNavMenu()
        {
            _collapseNavMenu = !_collapseNavMenu;
        }
    }
}
