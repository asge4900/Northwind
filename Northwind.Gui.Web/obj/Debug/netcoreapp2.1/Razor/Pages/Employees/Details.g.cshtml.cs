#pragma checksum "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0434517be49ff6718c787d28c490ee240c597dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Northwind.Gui.Web.Pages.Employees.Pages_Employees_Details), @"mvc.1.0.razor-page", @"/Pages/Employees/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Employees/Details.cshtml", typeof(Northwind.Gui.Web.Pages.Employees.Pages_Employees_Details), null)]
namespace Northwind.Gui.Web.Pages.Employees
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0434517be49ff6718c787d28c490ee240c597dd", @"/Pages/Employees/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39e39be22fe431478ed1af641a0629f2606c46b5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Employees_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            BeginContext(62, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(154, 122, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Employee</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(277, 53, false);
#line 16 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(330, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(374, 49, false);
#line 19 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(423, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(467, 54, false);
#line 22 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(521, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(565, 50, false);
#line 25 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(615, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(659, 53, false);
#line 28 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Initials));

#line default
#line hidden
            EndContext();
            BeginContext(712, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(756, 49, false);
#line 31 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Initials));

#line default
#line hidden
            EndContext();
            BeginContext(805, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(849, 50, false);
#line 34 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Title));

#line default
#line hidden
            EndContext();
            BeginContext(899, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(943, 46, false);
#line 37 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Title));

#line default
#line hidden
            EndContext();
            BeginContext(989, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1033, 60, false);
#line 40 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.TitleOfCourtesy));

#line default
#line hidden
            EndContext();
            BeginContext(1093, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1137, 56, false);
#line 43 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.TitleOfCourtesy));

#line default
#line hidden
            EndContext();
            BeginContext(1193, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1237, 54, false);
#line 46 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(1291, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1335, 50, false);
#line 49 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(1385, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1429, 53, false);
#line 52 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.HireDate));

#line default
#line hidden
            EndContext();
            BeginContext(1482, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1526, 49, false);
#line 55 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.HireDate));

#line default
#line hidden
            EndContext();
            BeginContext(1575, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1619, 52, false);
#line 58 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1671, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1715, 48, false);
#line 61 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1763, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1807, 49, false);
#line 64 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.City));

#line default
#line hidden
            EndContext();
            BeginContext(1856, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1900, 45, false);
#line 67 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.City));

#line default
#line hidden
            EndContext();
            BeginContext(1945, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1989, 51, false);
#line 70 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Region));

#line default
#line hidden
            EndContext();
            BeginContext(2040, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2084, 47, false);
#line 73 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Region));

#line default
#line hidden
            EndContext();
            BeginContext(2131, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2175, 55, false);
#line 76 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.PostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(2230, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2274, 51, false);
#line 79 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.PostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(2325, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2369, 52, false);
#line 82 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Country));

#line default
#line hidden
            EndContext();
            BeginContext(2421, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2465, 48, false);
#line 85 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Country));

#line default
#line hidden
            EndContext();
            BeginContext(2513, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2557, 54, false);
#line 88 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.HomePhone));

#line default
#line hidden
            EndContext();
            BeginContext(2611, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2655, 50, false);
#line 91 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.HomePhone));

#line default
#line hidden
            EndContext();
            BeginContext(2705, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2749, 54, false);
#line 94 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Extension));

#line default
#line hidden
            EndContext();
            BeginContext(2803, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2847, 50, false);
#line 97 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Extension));

#line default
#line hidden
            EndContext();
            BeginContext(2897, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2941, 50, false);
#line 100 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Notes));

#line default
#line hidden
            EndContext();
            BeginContext(2991, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3035, 46, false);
#line 103 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Notes));

#line default
#line hidden
            EndContext();
            BeginContext(3081, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3125, 54, false);
#line 106 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.PhotoPath));

#line default
#line hidden
            EndContext();
            BeginContext(3179, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3223, 50, false);
#line 109 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.PhotoPath));

#line default
#line hidden
            EndContext();
            BeginContext(3273, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3320, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2dbd69af3bf14e068a446214ae6b5b8a", async() => {
                BeginContext(3383, 4, true);
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
#line 114 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Details.cshtml"
                           WriteLiteral(Model.Employee.EmployeeID);

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
            BeginContext(3391, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3399, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2130d97a4479492dab6dd2dd196f5a17", async() => {
                BeginContext(3421, 12, true);
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
            BeginContext(3437, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Northwind.Gui.Web.Pages.Employees.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Northwind.Gui.Web.Pages.Employees.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Northwind.Gui.Web.Pages.Employees.DetailsModel>)PageContext?.ViewData;
        public Northwind.Gui.Web.Pages.Employees.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591