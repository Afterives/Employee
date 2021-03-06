#pragma checksum "C:\Projekt_inżyniernia\employee\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d0733f411a500dd17f071a62e5a3cf9b72bac46"
// <auto-generated/>
#pragma warning disable 1591
namespace employee.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Projekt_inżyniernia\employee\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projekt_inżyniernia\employee\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projekt_inżyniernia\employee\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projekt_inżyniernia\employee\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projekt_inżyniernia\employee\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Projekt_inżyniernia\employee\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Projekt_inżyniernia\employee\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Projekt_inżyniernia\employee\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Projekt_inżyniernia\employee\_Imports.razor"
using employee;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Projekt_inżyniernia\employee\_Imports.razor"
using employee.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Projekt_inżyniernia\employee\_Imports.razor"
using employee.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projekt_inżyniernia\employee\Shared\MainLayout.razor"
using employee.Authentication;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-4g0h9v4ed1");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-4g0h9v4ed1");
            __builder.OpenComponent<employee.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-4g0h9v4ed1");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "top-row px-4");
            __builder.AddAttribute(13, "b-4g0h9v4ed1");
            __builder.AddMarkupContent(14, "<a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\" b-4g0h9v4ed1>About</a>\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(15);
            __builder.AddAttribute(16, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(17, "a");
                __builder2.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Projekt_inżyniernia\employee\Shared\MainLayout.razor"
                                 Logout

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "href", "javascript:void(0)");
                __builder2.AddAttribute(20, "b-4g0h9v4ed1");
                __builder2.AddContent(21, "Logout");
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(22, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(23, "<a href=\"/login\" b-4g0h9v4ed1>Login</a>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n        ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "content px-4");
            __builder.AddAttribute(27, "b-4g0h9v4ed1");
            __builder.AddContent(28, 
#nullable restore
#line 24 "C:\Projekt_inżyniernia\employee\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Projekt_inżyniernia\employee\Shared\MainLayout.razor"
       
    private async Task Logout()
    {
        var customAuthStateProvider = (CustomAuthenticationStateProvider)authStateProvider;
        await customAuthStateProvider.UpdateAuthenticationState(null);
        navManager.NavigateTo("/", true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authStateProvider { get; set; }
    }
}
#pragma warning restore 1591
