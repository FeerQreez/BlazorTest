#pragma checksum "/Users/czapiain/TestWasm/Shared/SurveyPrompt.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "439c25382c766d2974156aca8f3da25236729dd8"
// <auto-generated/>
#pragma warning disable 1591
namespace TestWasm.Shared
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
    public partial class SurveyPrompt : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "alert alert-secondary mt-4");
            __builder.AddAttribute(2, "role", "alert");
            __builder.AddMarkupContent(3, "\r\n    <span class=\"oi oi-pencil mr-2\" aria-hidden=\"true\"></span>\r\n    ");
            __builder.OpenElement(4, "strong");
            __builder.AddContent(5, 
#line 3 "/Users/czapiain/TestWasm/Shared/SurveyPrompt.razor"
             Title

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n    ");
            __builder.AddMarkupContent(7, "<span class=\"text-nowrap\">\r\n        Please take our\r\n        <a target=\"_blank\" class=\"font-weight-bold\" href=\"https://go.microsoft.com/fwlink/?linkid=2100553\">brief survey</a>\r\n    </span>\r\n    and tell us what you think.\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 12 "/Users/czapiain/TestWasm/Shared/SurveyPrompt.razor"
       
    // Demonstrates how a parent component can supply parameters
    [Parameter]
    public string Title { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591