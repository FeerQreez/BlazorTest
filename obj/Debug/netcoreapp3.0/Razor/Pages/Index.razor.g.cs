#pragma checksum "/Users/czapiain/TestWasm/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6285d940f4ad7cc3091f6aea5c64e075f50a868d"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\n");
            __builder.OpenComponent<Telerik.Blazor.Components.TelerikButton>(1);
            __builder.AddAttribute(2, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "/Users/czapiain/TestWasm/Pages/Index.razor"
                         SayHelloHandler

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(4, "Say Hello");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenComponent<Telerik.Blazor.Components.TelerikButton>(6);
            __builder.AddAttribute(7, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "/Users/czapiain/TestWasm/Pages/Index.razor"
                         SayHelloHandler

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "Primary", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 6 "/Users/czapiain/TestWasm/Pages/Index.razor"
                                                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(10, "Say Hello");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n\r\n");
            __builder.OpenComponent<Telerik.Blazor.Components.TelerikCalendar>(12);
            __builder.AddAttribute(13, "Min", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime>(
#nullable restore
#line 8 "/Users/czapiain/TestWasm/Pages/Index.razor"
                       min

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "Max", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime>(
#nullable restore
#line 8 "/Users/czapiain/TestWasm/Pages/Index.razor"
                                  max

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.DateTime>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTime>(this, 
#nullable restore
#line 8 "/Users/czapiain/TestWasm/Pages/Index.razor"
                                                      MyValueChangeHandler

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(16, "Date", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime>(
#nullable restore
#line 8 "/Users/czapiain/TestWasm/Pages/Index.razor"
                                                                                         theDate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "DateChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.DateTime>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTime>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => theDate = __value, theDate))));
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\r\n\r\n\r\n<p></p>\r\nBasic chart and common settings/elements\r\n\r\n\r\n\r\n\r\n\r\nThe selected date is: ");
            __builder.AddContent(19, 
#nullable restore
#line 19 "/Users/czapiain/TestWasm/Pages/Index.razor"
                       selectedDate

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(20, "\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenComponent<TestWasm.Shared.SurveyPrompt>(21);
            __builder.AddAttribute(22, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
            __builder.AddMarkupContent(23, "\r\n\r\n");
            __builder.AddContent(24, 
#nullable restore
#line 25 "/Users/czapiain/TestWasm/Pages/Index.razor"
 helloString

#line default
#line hidden
#nullable disable
            );
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
