// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace employee.Pages.Components
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public partial class ToDo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Projekt_inżyniernia\employee\Pages\Components\ToDo.razor"
       
        // Kod C#
    protected List<TaskModel> tasklist = new List<TaskModel>();
    protected TaskModel task = new TaskModel();

    private void AddTask()
    {
        tasklist.Add(task);
        task = new TaskModel();
    }

    public int PercentageCompleted
    {
        get
        {
            return tasklist.Count > 0 ? (tasklist.Count(x => x.IsComplete) * 100 / tasklist.Count) : 0;
        }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
