#pragma checksum "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac337ef75172de4805c4b1ab2ac9a37d6e0c244d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Northwind.Gui.Web.Pages.Employees.Pages_Employees_Delete), @"mvc.1.0.razor-page", @"/Pages/Employees/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Employees/Delete.cshtml", typeof(Northwind.Gui.Web.Pages.Employees.Pages_Employees_Delete), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac337ef75172de4805c4b1ab2ac9a37d6e0c244d", @"/Pages/Employees/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39e39be22fe431478ed1af641a0629f2606c46b5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Employees_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(152, 169, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Employee</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(322, 53, false);
#line 17 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(375, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(419, 49, false);
#line 20 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(468, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(512, 54, false);
#line 23 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(566, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(610, 50, false);
#line 26 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(660, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(704, 53, false);
#line 29 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Initials));

#line default
#line hidden
            EndContext();
            BeginContext(757, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(801, 49, false);
#line 32 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Initials));

#line default
#line hidden
            EndContext();
            BeginContext(850, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(894, 50, false);
#line 35 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Title));

#line default
#line hidden
            EndContext();
            BeginContext(944, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(988, 46, false);
#line 38 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1034, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1078, 60, false);
#line 41 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.TitleOfCourtesy));

#line default
#line hidden
            EndContext();
            BeginContext(1138, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1182, 56, false);
#line 44 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee.TitleOfCourtesy));

#line default
#line hidden
            EndContext();
            BeginContext(1238, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1282, 54, false);
#line 47 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(1336, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1380, 50, false);
#line 50 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(1430, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1474, 53, false);
#line 53 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.HireDate));

#line default
#line hidden
            EndContext();
            BeginContext(1527, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1571, 49, false);
#line 56 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee.HireDate));

#line default
#line hidden
            EndContext();
            BeginContext(1620, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1664, 52, false);
#line 59 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1716, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1760, 48, false);
#line 62 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1808, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1852, 49, false);
#line 65 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.City));

#line default
#line hidden
            EndContext();
            BeginContext(1901, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1945, 45, false);
#line 68 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee.City));

#line default
#line hidden
            EndContext();
            BeginContext(1990, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2034, 51, false);
#line 71 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Region));

#line default
#line hidden
            EndContext();
            BeginContext(2085, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2129, 47, false);
#line 74 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Region));

#line default
#line hidden
            EndContext();
            BeginContext(2176, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2220, 55, false);
#line 77 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.PostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(2275, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2319, 51, false);
#line 80 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee.PostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(2370, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2414, 52, false);
#line 83 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Country));

#line default
#line hidden
            EndContext();
            BeginContext(2466, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2510, 48, false);
#line 86 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Country));

#line default
#line hidden
            EndContext();
            BeginContext(2558, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2602, 54, false);
#line 89 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.HomePhone));

#line default
#line hidden
            EndContext();
            BeginContext(2656, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2700, 50, false);
#line 92 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee.HomePhone));

#line default
#line hidden
            EndContext();
            BeginContext(2750, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2794, 54, false);
#line 95 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Extension));

#line default
#line hidden
            EndContext();
            BeginContext(2848, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2892, 50, false);
#line 98 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Extension));

#line default
#line hidden
            EndContext();
            BeginContext(2942, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2986, 50, false);
#line 101 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Notes));

#line default
#line hidden
            EndContext();
            BeginContext(3036, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3080, 46, false);
#line 104 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Notes));

#line default
#line hidden
            EndContext();
            BeginContext(3126, 17, true);
            WriteLiteral("\r\n        </dd>\r\n");
            EndContext();
            BeginContext(3339, 21, true);
            WriteLiteral("    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(3360, 218, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a93dc581b9d64bd79015daad2ad76ec1", async() => {
                BeginContext(3380, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(3390, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "edd086eb8e6c47348730a4159e000620", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 115 "C:\Users\asge4900\source\repos\Northwind\Northwind.Gui.Web\Pages\Employees\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Employee.EmployeeID);

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
                BeginContext(3443, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(3527, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29feb7fe50eb40afba87f402ecd37bbd", async() => {
                    BeginContext(3549, 12, true);
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
                BeginContext(3565, 6, true);
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
            BeginContext(3578, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Northwind.Gui.Web.Pages.Employees.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Northwind.Gui.Web.Pages.Employees.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Northwind.Gui.Web.Pages.Employees.DeleteModel>)PageContext?.ViewData;
        public Northwind.Gui.Web.Pages.Employees.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
