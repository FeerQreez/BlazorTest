#pragma checksum "/Users/czapiain/TestWasm/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6285d940f4ad7cc3091f6aea5c64e075f50a868d"
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
#nullable restore
#line 1 "/Users/czapiain/TestWasm/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/czapiain/TestWasm/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/czapiain/TestWasm/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/czapiain/TestWasm/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/czapiain/TestWasm/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/czapiain/TestWasm/_Imports.razor"
using TestWasm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/czapiain/TestWasm/_Imports.razor"
using TestWasm.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/czapiain/TestWasm/_Imports.razor"
using Telerik.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/czapiain/TestWasm/_Imports.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "/Users/czapiain/TestWasm/Pages/Index.razor"
       

    public class ModelData
    {
        public double Series1 { get; set; }
        public double Series2 { get; set; }
        public double Series3 { get; set; }
    }

    public string[] Categories = new string[] { "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011" };

    public object[] AxisCrossingValue = new object[] { -10 };


    public List<ModelData> Data = new List<ModelData>()
    {
        new ModelData()
        {
            Series1 = 3.907,
            Series2 = 1.988,
            Series3 = -0.253
        },
        new ModelData()
        {
            Series1 = 7.943,
            Series2 = 2.733,
            Series3 = 0.362
        },
        new ModelData()
        {
            Series1 = 7.848,
            Series2 = 3.994,
            Series3 = -3.519
        },
        new ModelData()
        {
            Series1 = 9.284,
            Series2 = 3.464,
            Series3 = 1.799
        },
        new ModelData()
        {
            Series1 = 9.263,
            Series2 = 4.001,
            Series3 = 2.252
        },
        new ModelData()
        {
            Series1 = 9.801,
            Series2 = 3.939,
            Series3 = 3.343
        },
        new ModelData()
        {
            Series1 = 3.89,
            Series2 = 1.333,
            Series3 = 0.843
        },
        new ModelData()
        {
            Series1 = 8.238,
            Series2 = -2.245,
            Series3 = 2.877
        },
        new ModelData()
        {
            Series1 = 9.552,
            Series2 = 4.339,
            Series3 = -5.416
        },
        new ModelData()
        {
            Series1 = 6.855,
            Series2 = 2.727,
            Series3 = 5.59
        }
    };
    

    private DateTime min = new DateTime(2015, 1, 1);
    private DateTime max = new DateTime(2025, 12, 31);
    private DateTime theDate { get; set; } = DateTime.Now;
    private string selectedDate = "";

    private void MyValueChangeHandler(DateTime newValue)
    {
        selectedDate = newValue.ToString("dd MMM yyyy");
    }

   MarkupString helloString;

   void SayHelloHandler()
   {
       string msg = string.Format("Hello from <strong>Telerik Blazor</strong> at {0}.<br /> Now you can use C# to write front-end!", DateTime.Now);
       helloString = new MarkupString(msg);
   }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
