#pragma checksum "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "beeda07fcc19ef850809006bfa98148fe3c128cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Northwind.Gui.Web.Pages.Orders.Pages_Orders_Delete), @"mvc.1.0.razor-page", @"/Pages/Orders/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Orders/Delete.cshtml", typeof(Northwind.Gui.Web.Pages.Orders.Pages_Orders_Delete), null)]
namespace Northwind.Gui.Web.Pages.Orders
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\_ViewImports.cshtml"
using Northwind.Gui.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"beeda07fcc19ef850809006bfa98148fe3c128cd", @"/Pages/Orders/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39e39be22fe431478ed1af641a0629f2606c46b5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Orders_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(149, 166, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Order</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(316, 51, false);
#line 17 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Order.OrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(367, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(411, 47, false);
#line 20 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Order.OrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(458, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(502, 54, false);
#line 23 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Order.RequiredDate));

#line default
#line hidden
            EndContext();
            BeginContext(556, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(600, 50, false);
#line 26 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Order.RequiredDate));

#line default
#line hidden
            EndContext();
            BeginContext(650, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(694, 53, false);
#line 29 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Order.ShippedDate));

#line default
#line hidden
            EndContext();
            BeginContext(747, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(791, 49, false);
#line 32 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Order.ShippedDate));

#line default
#line hidden
            EndContext();
            BeginContext(840, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(884, 49, false);
#line 35 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Order.Freight));

#line default
#line hidden
            EndContext();
            BeginContext(933, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(977, 45, false);
#line 38 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Order.Freight));

#line default
#line hidden
            EndContext();
            BeginContext(1022, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1066, 50, false);
#line 41 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Order.ShipName));

#line default
#line hidden
            EndContext();
            BeginContext(1116, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1160, 46, false);
#line 44 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Order.ShipName));

#line default
#line hidden
            EndContext();
            BeginContext(1206, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1250, 53, false);
#line 47 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Order.ShipAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1303, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1347, 49, false);
#line 50 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Order.ShipAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1396, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1440, 50, false);
#line 53 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Order.ShipCity));

#line default
#line hidden
            EndContext();
            BeginContext(1490, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1534, 46, false);
#line 56 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Order.ShipCity));

#line default
#line hidden
            EndContext();
            BeginContext(1580, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1624, 52, false);
#line 59 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Order.ShipRegion));

#line default
#line hidden
            EndContext();
            BeginContext(1676, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1720, 48, false);
#line 62 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Order.ShipRegion));

#line default
#line hidden
            EndContext();
            BeginContext(1768, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1812, 56, false);
#line 65 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Order.ShipPostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(1868, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1912, 52, false);
#line 68 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Order.ShipPostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(1964, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2008, 53, false);
#line 71 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Order.ShipCountry));

#line default
#line hidden
            EndContext();
            BeginContext(2061, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2105, 49, false);
#line 74 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Order.ShipCountry));

#line default
#line hidden
            EndContext();
            BeginContext(2154, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2198, 50, false);
#line 77 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Order.Customer));

#line default
#line hidden
            EndContext();
            BeginContext(2248, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2292, 57, false);
#line 80 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Order.Customer.CustomerId));

#line default
#line hidden
            EndContext();
            BeginContext(2349, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2393, 50, false);
#line 83 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Order.Employee));

#line default
#line hidden
            EndContext();
            BeginContext(2443, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2487, 54, false);
#line 86 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Order.Employee.Address));

#line default
#line hidden
            EndContext();
            BeginContext(2541, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2585, 59, false);
#line 89 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Order.ShipViaNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2644, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2688, 67, false);
#line 92 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Order.ShipViaNavigation.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(2755, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2793, 212, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42139533784547a49249f6d57307c7f9", async() => {
                BeginContext(2813, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2823, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "059350a557f24e179cf5da3cde64ef29", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 97 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Order.OrderId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2870, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2954, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "552b7df018924bc3bf0c89765b067019", async() => {
                    BeginContext(2976, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2992, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3005, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Northwind.Gui.Web.Pages.Orders.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Northwind.Gui.Web.Pages.Orders.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Northwind.Gui.Web.Pages.Orders.DeleteModel>)PageContext?.ViewData;
        public Northwind.Gui.Web.Pages.Orders.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
