#pragma checksum "C:\Projekt_inżyniernia\employee\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29cb4e623b385ce595bdffe279bd98660df5c518"
// <auto-generated/>
#pragma warning disable 1591
namespace employee.Pages
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
#line 2 "C:\Projekt_inżyniernia\employee\Pages\Login.razor"
using employee.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-lg-4 offset-lg-4 pt-4 pb-4 border");
            __builder.AddMarkupContent(4, "<div class=\"mb-3 text-center\"><h3>LOGIN</h3></div>\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "mb-3");
            __builder.AddMarkupContent(7, "<label>Login</label>\r\n            ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "class", "form-control");
            __builder.AddAttribute(10, "placeholder", "Login");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Projekt_inżyniernia\employee\Pages\Login.razor"
                          model.UserName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => model.UserName = __value, model.UserName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "mb-3");
            __builder.AddMarkupContent(16, "<label>Hasło</label>\r\n            ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "type", "password");
            __builder.AddAttribute(19, "class", "form-control");
            __builder.AddAttribute(20, "placeholder", "Hasło");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Projekt_inżyniernia\employee\Pages\Login.razor"
                          model.Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => model.Password = __value, model.Password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "mb-3 d-grid gap-2");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Projekt_inżyniernia\employee\Pages\Login.razor"
                              Authenticate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "class", "btn btn-primary");
            __builder.AddMarkupContent(29, "Zaloguj się");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Projekt_inżyniernia\employee\Pages\Login.razor"
       
    private class Model
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    private Model model = new Model();

    private async Task Authenticate()
    {
        var userAccount = userAccountService.GetByUserName(model.UserName);
        if (userAccount == null || userAccount.Password != model.Password)
        {
            await js.InvokeVoidAsync("alert", "Invalid User Name or Password");
            return;
        }

        var customAuthStateProvider = (CustomAuthenticationStateProvider)authStateProvider;
        await customAuthStateProvider.UpdateAuthenticationState(new UserSession
        {
            UserName = userAccount.UserName,
            Role = userAccount.Role
        });
        navManager.NavigateTo("/", true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserAccountService userAccountService { get; set; }
    }
}
#pragma warning restore 1591
