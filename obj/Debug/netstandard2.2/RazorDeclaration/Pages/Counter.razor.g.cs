#pragma checksum "/Users/czapiain/TestWasm/Pages/Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7eb1d889efebd26dd0619148f11cc18a90bfab20"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TestWasm.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "/Users/czapiain/TestWasm/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "/Users/czapiain/TestWasm/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "/Users/czapiain/TestWasm/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "/Users/czapiain/TestWasm/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "/Users/czapiain/TestWasm/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "/Users/czapiain/TestWasm/_Imports.razor"
using TestWasm;

#line default
#line hidden
#line 7 "/Users/czapiain/TestWasm/_Imports.razor"
using TestWasm.Shared;

#line default
#line hidden
#line 8 "/Users/czapiain/TestWasm/_Imports.razor"
using Telerik.Blazor;

#line default
#line hidden
#line 9 "/Users/czapiain/TestWasm/_Imports.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 21 "/Users/czapiain/TestWasm/Pages/Counter.razor"
       

    private bool loadFailed;

    private int currentCount = 0;
    public DateTime? selectedTime = DateTime.Now;

    // only the time portions are used
    public DateTime Min = new DateTime(1900, 1, 1, 8, 15, 0);
    public DateTime Max = new DateTime(1900, 1, 1, 19, 30, 45);

    private void IncrementCount()
    {
        currentCount++;
    }



#line default
#line hidden
    }
}
#pragma warning restore 1591