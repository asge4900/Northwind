#pragma checksum "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75176793337b902fb4867ecc83e0e9a0d8037c45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Northwind.Gui.Web.Pages.Orders.Pages_Orders_Details), @"mvc.1.0.razor-page", @"/Pages/Orders/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Orders/Details.cshtml", typeof(Northwind.Gui.Web.Pages.Orders.Pages_Orders_Details), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75176793337b902fb4867ecc83e0e9a0d8037c45", @"/Pages/Orders/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39e39be22fe431478ed1af641a0629f2606c46b5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Orders_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(151, 119, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Order</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(271, 51, false);
#line 16 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Order.OrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(322, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(366, 47, false);
#line 19 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Order.OrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(413, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(457, 54, false);
#line 22 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Order.RequiredDate));

#line default
#line hidden
            EndContext();
            BeginContext(511, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(555, 50, false);
#line 25 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Order.RequiredDate));

#line default
#line hidden
            EndContext();
            BeginContext(605, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(649, 53, false);
#line 28 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Order.ShippedDate));

#line default
#line hidden
            EndContext();
            BeginContext(702, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(746, 49, false);
#line 31 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Order.ShippedDate));

#line default
#line hidden
            EndContext();
            BeginContext(795, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(839, 49, false);
#line 34 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Order.Freight));

#line default
#line hidden
            EndContext();
            BeginContext(888, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(932, 45, false);
#line 37 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Order.Freight));

#line default
#line hidden
            EndContext();
            BeginContext(977, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1021, 50, false);
#line 40 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Order.ShipName));

#line default
#line hidden
            EndContext();
            BeginContext(1071, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1115, 46, false);
#line 43 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Order.ShipName));

#line default
#line hidden
            EndContext();
            BeginContext(1161, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1205, 53, false);
#line 46 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Order.ShipAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1258, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1302, 49, false);
#line 49 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Order.ShipAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1351, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1395, 50, false);
#line 52 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Order.ShipCity));

#line default
#line hidden
            EndContext();
            BeginContext(1445, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1489, 46, false);
#line 55 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Order.ShipCity));

#line default
#line hidden
            EndContext();
            BeginContext(1535, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1579, 52, false);
#line 58 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Order.ShipRegion));

#line default
#line hidden
            EndContext();
            BeginContext(1631, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1675, 48, false);
#line 61 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Order.ShipRegion));

#line default
#line hidden
            EndContext();
            BeginContext(1723, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1767, 56, false);
#line 64 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Order.ShipPostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(1823, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1867, 52, false);
#line 67 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Order.ShipPostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(1919, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1963, 53, false);
#line 70 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Order.ShipCountry));

#line default
#line hidden
            EndContext();
            BeginContext(2016, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2060, 49, false);
#line 73 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Order.ShipCountry));

#line default
#line hidden
            EndContext();
            BeginContext(2109, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2153, 50, false);
#line 76 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Order.Customer));

#line default
#line hidden
            EndContext();
            BeginContext(2203, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2247, 57, false);
#line 79 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Order.Customer.CustomerId));

#line default
#line hidden
            EndContext();
            BeginContext(2304, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2348, 50, false);
#line 82 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Order.Employee));

#line default
#line hidden
            EndContext();
            BeginContext(2398, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2442, 54, false);
#line 85 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Order.Employee.Address));

#line default
#line hidden
            EndContext();
            BeginContext(2496, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2540, 59, false);
#line 88 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Order.ShipViaNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(2599, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2643, 67, false);
#line 91 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Order.ShipViaNavigation.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(2710, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2757, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "133f98ce319e49279bc15be54c5cb70f", async() => {
                BeginContext(2814, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 96 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Orders\Details.cshtml"
                           WriteLiteral(Model.Order.OrderId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2822, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2830, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd4e0acf46c1476c86e94bdd63c659b8", async() => {
                BeginContext(2852, 12, true);
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
            BeginContext(2868, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Northwind.Gui.Web.Pages.Orders.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Northwind.Gui.Web.Pages.Orders.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Northwind.Gui.Web.Pages.Orders.DetailsModel>)PageContext?.ViewData;
        public Northwind.Gui.Web.Pages.Orders.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
