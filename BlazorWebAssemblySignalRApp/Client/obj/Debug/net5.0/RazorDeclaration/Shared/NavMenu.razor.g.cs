// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorWebAssemblySignalRApp.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\hp\OneDrive\Documents\GitHub\BlazorWebAssemblySignalRApp\BlazorWebAssemblySignalRApp\BlazorWebAssemblySignalRApp\client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\OneDrive\Documents\GitHub\BlazorWebAssemblySignalRApp\BlazorWebAssemblySignalRApp\BlazorWebAssemblySignalRApp\client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\OneDrive\Documents\GitHub\BlazorWebAssemblySignalRApp\BlazorWebAssemblySignalRApp\BlazorWebAssemblySignalRApp\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hp\OneDrive\Documents\GitHub\BlazorWebAssemblySignalRApp\BlazorWebAssemblySignalRApp\BlazorWebAssemblySignalRApp\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hp\OneDrive\Documents\GitHub\BlazorWebAssemblySignalRApp\BlazorWebAssemblySignalRApp\BlazorWebAssemblySignalRApp\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hp\OneDrive\Documents\GitHub\BlazorWebAssemblySignalRApp\BlazorWebAssemblySignalRApp\BlazorWebAssemblySignalRApp\client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hp\OneDrive\Documents\GitHub\BlazorWebAssemblySignalRApp\BlazorWebAssemblySignalRApp\BlazorWebAssemblySignalRApp\client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hp\OneDrive\Documents\GitHub\BlazorWebAssemblySignalRApp\BlazorWebAssemblySignalRApp\BlazorWebAssemblySignalRApp\client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\hp\OneDrive\Documents\GitHub\BlazorWebAssemblySignalRApp\BlazorWebAssemblySignalRApp\BlazorWebAssemblySignalRApp\client\_Imports.razor"
using BlazorWebAssemblySignalRApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\hp\OneDrive\Documents\GitHub\BlazorWebAssemblySignalRApp\BlazorWebAssemblySignalRApp\BlazorWebAssemblySignalRApp\client\_Imports.razor"
using BlazorWebAssemblySignalRApp.Client.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\hp\OneDrive\Documents\GitHub\BlazorWebAssemblySignalRApp\BlazorWebAssemblySignalRApp\BlazorWebAssemblySignalRApp\client\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
