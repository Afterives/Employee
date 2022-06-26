// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Projekt_inżyniernia\employee\Pages\Chat.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projekt_inżyniernia\employee\Pages\Chat.razor"
using Data.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/chat")]
    public partial class Chat : Microsoft.AspNetCore.Components.ComponentBase, IAsyncDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Projekt_inżyniernia\employee\Pages\Chat.razor"
       
    private HubConnection hubConnection;
    private List<UserMessage> userMessages = new();
    private string usernameInput;
    private string messageInput;
    private bool isUserReadonly = false;

    public bool IsConnected => hubConnection.State == HubConnectionState.Connected;

    protected override async Task OnInitializedAsync()
    {
        hubConnection = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/chathub"))
            .Build();

        hubConnection.On<string, string>("ReceiveMessage", (user, message) =>
        {
            userMessages.Add(new UserMessage { UserName = user, Message = message, CurrentUser = user == usernameInput, DateSent = DateTime.Now});

            StateHasChanged();
        });

        await hubConnection.StartAsync();
    }

    private async Task Send()
    {
        if (!string.IsNullOrEmpty(usernameInput) && !string.IsNullOrEmpty(messageInput))
        {
            await hubConnection.SendAsync("SendMessage", usernameInput, messageInput);

            isUserReadonly = true;
            messageInput = string.Empty;
        }
    }

    public async ValueTask DisposeAsync()
    {
        if (hubConnection is not null)
        {
            await hubConnection.DisposeAsync();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591