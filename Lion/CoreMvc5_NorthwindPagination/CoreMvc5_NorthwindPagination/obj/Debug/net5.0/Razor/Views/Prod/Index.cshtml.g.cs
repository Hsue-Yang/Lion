#pragma checksum "C:\Users\User\Desktop\軟體\MVC\ASP.NET Core 7 MVC課程資料\範例程式\CoreMvc5_NorthwindPagination\CoreMvc5_NorthwindPagination\Views\Prod\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e121482e572636e971b23ad43ecbae5bbacbad3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Prod_Index), @"mvc.1.0.view", @"/Views/Prod/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\User\Desktop\軟體\MVC\ASP.NET Core 7 MVC課程資料\範例程式\CoreMvc5_NorthwindPagination\CoreMvc5_NorthwindPagination\Views\_ViewImports.cshtml"
using CoreMvc5_NorthwindPagination;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\軟體\MVC\ASP.NET Core 7 MVC課程資料\範例程式\CoreMvc5_NorthwindPagination\CoreMvc5_NorthwindPagination\Views\_ViewImports.cshtml"
using CoreMvc5_NorthwindPagination.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e121482e572636e971b23ad43ecbae5bbacbad3", @"/Views/Prod/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9392c60fa19651fdb3aa732a9eb43d0c2e02e4c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Prod_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoreMvc5_NorthwindPagination.Models.Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\Desktop\軟體\MVC\ASP.NET Core 7 MVC課程資料\範例程式\CoreMvc5_NorthwindPagination\CoreMvc5_NorthwindPagination\Views\Prod\Index.cshtml"
  
    ViewData["Title"] = "Index";

    int activePage = (int)ViewData["ActivePage"];
    int pages = (int)ViewData["Pages"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e121482e572636e971b23ad43ecbae5bbacbad34997", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\User\Desktop\軟體\MVC\ASP.NET Core 7 MVC課程資料\範例程式\CoreMvc5_NorthwindPagination\CoreMvc5_NorthwindPagination\Views\Prod\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\User\Desktop\軟體\MVC\ASP.NET Core 7 MVC課程資料\範例程式\CoreMvc5_NorthwindPagination\CoreMvc5_NorthwindPagination\Views\Prod\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.QuantityPerUnit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\User\Desktop\軟體\MVC\ASP.NET Core 7 MVC課程資料\範例程式\CoreMvc5_NorthwindPagination\CoreMvc5_NorthwindPagination\Views\Prod\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\User\Desktop\軟體\MVC\ASP.NET Core 7 MVC課程資料\範例程式\CoreMvc5_NorthwindPagination\CoreMvc5_NorthwindPagination\Views\Prod\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UnitsInStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\User\Desktop\軟體\MVC\ASP.NET Core 7 MVC課程資料\範例程式\CoreMvc5_NorthwindPagination\CoreMvc5_NorthwindPagination\Views\Prod\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UnitsOnOrder));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\User\Desktop\軟體\MVC\ASP.NET Core 7 MVC課程資料\範例程式\CoreMvc5_NorthwindPagination\CoreMvc5_NorthwindPagination\Views\Prod\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ReorderLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\User\Desktop\軟體\MVC\ASP.NET Core 7 MVC課程資料\範例程式\CoreMvc5_NorthwindPagination\CoreMvc5_NorthwindPagination\Views\Prod\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Discontinued));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\User\Desktop\軟體\MVC\ASP.NET Core 7 MVC課程資料\範例程式\CoreMvc5_NorthwindPagination\CoreMvc5_NorthwindPagination\Views\Prod\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Users\User\Desktop\軟體\MVC\ASP.NET Core 7 MVC課程資料\範例程式\CoreMvc5_NorthwindPagination\CoreMvc5_NorthwindPagination\Views\Prod\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Supplier));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 49 "C:\Users\User\Desktop\軟體\MVC\ASP.NET Core 7 MVC課程資料\範例程式\CoreMvc5_NorthwindPagination\CoreMvc5_NorthwindPagination\Views\Prod\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "C:\Users\User\Desktop\軟體\MVC\ASP.NET Core 7 MVC課程資料\範例程式\CoreMvc5_NorthwindPagination\CoreMvc5_NorthwindPagination\Views\Prod\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "C:\Users\User\Desktop\軟體\MVC\ASP.NET Core 7 MVC課程資料\範例程式\CoreMvc5_NorthwindPagination\CoreMvc5_NorthwindPagination\Views\Prod\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.QuantityPerUnit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 59 "C:\Users\User\Desktop\軟體\MVC\ASP.NET Core 7 MVC課程資料\範例程式\CoreMvc5_NorthwindPagination\CoreMvc5_NorthwindPagination\Views\Prod\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 62 "C:\Users\User\Desktop\軟體\MVC\ASP.NET Core 7 MVC課程資料\範例程式\CoreMvc5_NorthwindPagination\CoreMvc5_NorthwindPagination\Views\Prod\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.UnitsInStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 65 "C:\Users\User\Desktop\軟體\MVC\ASP.NET Core 7 MVC課程資料\範例程式\CoreMvc5_NorthwindPagination\CoreMvc5_NorthwindPagination\Views\Prod\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.UnitsOnOrder));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 68 "C:\Users\User\Desktop\軟體\MVC\ASP.NET Core 7 MVC課程資料\範例程式\CoreMvc5_NorthwindPagination\CoreMvc5_NorthwindPagination\Views\Prod\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ReorderLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 71 "C:\Users\User\Desktop\軟體\MVC\ASP.NET Core 7 MVC課程資料\範例程式\CoreMvc5_NorthwindPagination\CoreMvc5_NorthwindPagination\Views\Prod\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Discontinued));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 74 "C:\Users\User\Desktop\軟體\MVC\ASP.NET Core 7 MVC課程資料\範例程式\CoreMvc5_NorthwindPagination\CoreMvc5_NorthwindPagination\Views\Prod\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Category.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 77 "C:\Users\User\Desktop\軟體\MVC\ASP.NET Core 7 MVC課程資料\範例程式\CoreMvc5_NorthwindPagination\CoreMvc5_NorthwindPagination\Views\Prod\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Supplier.CompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e121482e572636e971b23ad43ecbae5bbacbad313659", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "C:\Users\User\Desktop\軟體\MVC\ASP.NET Core 7 MVC課程資料\範例程式\CoreMvc5_NorthwindPagination\CoreMvc5_NorthwindPagination\Views\Prod\Index.cshtml"
                                           WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e121482e572636e971b23ad43ecbae5bbacbad315899", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 81 "C:\Users\User\Desktop\軟體\MVC\ASP.NET Core 7 MVC課程資料\範例程式\CoreMvc5_NorthwindPagination\CoreMvc5_NorthwindPagination\Views\Prod\Index.cshtml"
                                              WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e121482e572636e971b23ad43ecbae5bbacbad318145", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "C:\Users\User\Desktop\軟體\MVC\ASP.NET Core 7 MVC課程資料\範例程式\CoreMvc5_NorthwindPagination\CoreMvc5_NorthwindPagination\Views\Prod\Index.cshtml"
                                             WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 85 "C:\Users\User\Desktop\軟體\MVC\ASP.NET Core 7 MVC課程資料\範例程式\CoreMvc5_NorthwindPagination\CoreMvc5_NorthwindPagination\Views\Prod\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<nav aria-label=\"Page navigation example\">\r\n    <ul class=\"pagination\">\r\n        <li class=\"page-item\"><a class=\"page-link\" href=\"#\">Previous</a></li>\r\n\r\n");
#nullable restore
#line 93 "C:\Users\User\Desktop\軟體\MVC\ASP.NET Core 7 MVC課程資料\範例程式\CoreMvc5_NorthwindPagination\CoreMvc5_NorthwindPagination\Views\Prod\Index.cshtml"
         for (int i = 1; i <= pages; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li");
            BeginWriteAttribute("class", " class=\"", 3020, "\"", 3067, 2);
            WriteAttributeValue("", 3028, "page-item", 3028, 9, true);
#nullable restore
#line 95 "C:\Users\User\Desktop\軟體\MVC\ASP.NET Core 7 MVC課程資料\範例程式\CoreMvc5_NorthwindPagination\CoreMvc5_NorthwindPagination\Views\Prod\Index.cshtml"
WriteAttributeValue(" ", 3037, i==activePage? "active":"", 3038, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3089, "\"", 3110, 2);
            WriteAttributeValue("", 3096, "/Prod/Index/", 3096, 12, true);
#nullable restore
#line 95 "C:\Users\User\Desktop\軟體\MVC\ASP.NET Core 7 MVC課程資料\範例程式\CoreMvc5_NorthwindPagination\CoreMvc5_NorthwindPagination\Views\Prod\Index.cshtml"
WriteAttributeValue("", 3108, i, 3108, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 95 "C:\Users\User\Desktop\軟體\MVC\ASP.NET Core 7 MVC課程資料\範例程式\CoreMvc5_NorthwindPagination\CoreMvc5_NorthwindPagination\Views\Prod\Index.cshtml"
                                                                                                      Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 96 "C:\Users\User\Desktop\軟體\MVC\ASP.NET Core 7 MVC課程資料\範例程式\CoreMvc5_NorthwindPagination\CoreMvc5_NorthwindPagination\Views\Prod\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n        <li class=\"page-item\"><a class=\"page-link\" href=\"#\">Next</a></li>\r\n    </ul>\r\n</nav>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoreMvc5_NorthwindPagination.Models.Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
