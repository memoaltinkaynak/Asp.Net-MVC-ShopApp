#pragma checksum "C:\Users\memo\OneDrive\Masaüstü\ShopApp\ShopApp\Views\Admin\CategoryList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b65728e5c7e94fd7184a3fa989adf98a36d2523d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CategoryList), @"mvc.1.0.view", @"/Views/Admin/CategoryList.cshtml")]
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
#line 2 "C:\Users\memo\OneDrive\Masaüstü\ShopApp\ShopApp\Views\_ViewImports.cshtml"
using ShopApp.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\memo\OneDrive\Masaüstü\ShopApp\ShopApp\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\memo\OneDrive\Masaüstü\ShopApp\ShopApp\Views\_ViewImports.cshtml"
using ShopApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b65728e5c7e94fd7184a3fa989adf98a36d2523d", @"/Views/Admin/CategoryList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc86b51a736886deefefed3d501fae4f997907bc", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_CategoryList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoryListViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/DeleteCategory"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        <h1>Admin Categories</h1>
        <hr>
        <a href=""/admin/categorycreate"" class=""btn btn-primary btn-sm mr2"">Add Category</a>

        <table class=""table table-bordered"">
            <thead>
                <tr>
                    <td style=""width: 30px;"">Id</td>
                    <td style=""width: 20px;"">Name</td>
                    <td style=""width: 30px;"">Url</td>
                    <td style=""width: 150px;""></td>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 19 "C:\Users\memo\OneDrive\Masaüstü\ShopApp\ShopApp\Views\Admin\CategoryList.cshtml"
                 if (Model.Categories.Count > 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\memo\OneDrive\Masaüstü\ShopApp\ShopApp\Views\Admin\CategoryList.cshtml"
                     foreach (var item in Model.Categories)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 24 "C:\Users\memo\OneDrive\Masaüstü\ShopApp\ShopApp\Views\Admin\CategoryList.cshtml"
                           Write(item.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 25 "C:\Users\memo\OneDrive\Masaüstü\ShopApp\ShopApp\Views\Admin\CategoryList.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 26 "C:\Users\memo\OneDrive\Masaüstü\ShopApp\ShopApp\Views\Admin\CategoryList.cshtml"
                           Write(item.Url);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                            <td>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1002, "\"", 1043, 2);
            WriteAttributeValue("", 1009, "/admin/categories/", 1009, 18, true);
#nullable restore
#line 29 "C:\Users\memo\OneDrive\Masaüstü\ShopApp\ShopApp\Views\Admin\CategoryList.cshtml"
WriteAttributeValue("", 1027, item.CategoryId, 1027, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm mr2\">Edit</a>\r\n\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b65728e5c7e94fd7184a3fa989adf98a36d2523d7077", async() => {
                WriteLiteral("\r\n                                    <input type=\"hidden\" name=\"categoryId\"");
                BeginWriteAttribute("value", " value=\"", 1275, "\"", 1299, 1);
#nullable restore
#line 32 "C:\Users\memo\OneDrive\Masaüstü\ShopApp\ShopApp\Views\Admin\CategoryList.cshtml"
WriteAttributeValue("", 1283, item.CategoryId, 1283, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <button type=\"submit\" class=\"btn btn-danger btn-sm text-white\">Delete</button>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 38 "C:\Users\memo\OneDrive\Masaüstü\ShopApp\ShopApp\Views\Admin\CategoryList.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\memo\OneDrive\Masaüstü\ShopApp\ShopApp\Views\Admin\CategoryList.cshtml"
                     
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-danger\">\r\n                        <h3>No Categories</h3>\r\n                    </div>\r\n");
#nullable restore
#line 45 "C:\Users\memo\OneDrive\Masaüstü\ShopApp\ShopApp\Views\Admin\CategoryList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoryListViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
