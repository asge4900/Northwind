#pragma checksum "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\OrderDetails\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d654a67607623272c2f46da378f222d84c3993e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Northwind.Gui.Web.Pages.OrderDetails.Pages_OrderDetails_Index), @"mvc.1.0.razor-page", @"/Pages/OrderDetails/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/OrderDetails/Index.cshtml", typeof(Northwind.Gui.Web.Pages.OrderDetails.Pages_OrderDetails_Index), null)]
namespace Northwind.Gui.Web.Pages.OrderDetails
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d654a67607623272c2f46da378f222d84c3993e", @"/Pages/OrderDetails/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39e39be22fe431478ed1af641a0629f2606c46b5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_OrderDetails_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\OrderDetails\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(153, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(182, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb628eda72234605a9ff1ee2817e9a5b", async() => {
                BeginContext(203, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(217, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(310, 60, false);
#line 18 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\OrderDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderDetail[0].UnitPrice));

#line default
#line hidden
            EndContext();
            BeginContext(370, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(426, 59, false);
#line 21 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\OrderDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderDetail[0].Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(485, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(541, 59, false);
#line 24 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\OrderDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderDetail[0].Discount));

#line default
#line hidden
            EndContext();
            BeginContext(600, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(656, 56, false);
#line 27 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\OrderDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderDetail[0].Order));

#line default
#line hidden
            EndContext();
            BeginContext(712, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(768, 58, false);
#line 30 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\OrderDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderDetail[0].Product));

#line default
#line hidden
            EndContext();
            BeginContext(826, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 36 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\OrderDetails\Index.cshtml"
 foreach (var item in Model.OrderDetail) {

#line default
#line hidden
            BeginContext(956, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1005, 44, false);
#line 39 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\OrderDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UnitPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1049, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1105, 43, false);
#line 42 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\OrderDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(1148, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1204, 43, false);
#line 45 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\OrderDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Discount));

#line default
#line hidden
            EndContext();
            BeginContext(1247, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1303, 48, false);
#line 48 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\OrderDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Order.OrderId));

#line default
#line hidden
            EndContext();
            BeginContext(1351, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1407, 52, false);
#line 51 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\OrderDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Product.ProductId));

#line default
#line hidden
            EndContext();
            BeginContext(1459, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1515, 65, false);
#line 54 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\OrderDetails\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1580, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1601, 71, false);
#line 55 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\OrderDetails\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1672, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1693, 69, false);
#line 56 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\OrderDetails\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1762, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 59 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\OrderDetails\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1801, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Northwind.Gui.Web.Pages.OrderDetails.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Northwind.Gui.Web.Pages.OrderDetails.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Northwind.Gui.Web.Pages.OrderDetails.IndexModel>)PageContext?.ViewData;
        public Northwind.Gui.Web.Pages.OrderDetails.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591