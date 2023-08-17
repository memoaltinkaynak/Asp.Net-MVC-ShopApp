#pragma checksum "C:\Users\memo\OneDrive\Masaüstü\ShopApp\ShopApp\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb070fd73ef5d51d19ab75d0de3b53ff633e9069"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
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
#line 1 "C:\Users\memo\OneDrive\Masaüstü\ShopApp\ShopApp\Views\Product\List.cshtml"
using ShopApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb070fd73ef5d51d19ab75d0de3b53ff633e9069", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc86b51a736886deefefed3d501fae4f997907bc", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\memo\OneDrive\Masaüstü\ShopApp\ShopApp\Views\Product\List.cshtml"
  
    var popularClass = Model.Products.Count > 2 ? "popular" : "";
    var products = Model.Products;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Categories", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 11 "C:\Users\memo\OneDrive\Masaüstü\ShopApp\ShopApp\Views\Product\List.cshtml"
Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 15 "C:\Users\memo\OneDrive\Masaüstü\ShopApp\ShopApp\Views\Product\List.cshtml"
 if (products.Count == 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\memo\OneDrive\Masaüstü\ShopApp\ShopApp\Views\Product\List.cshtml"
Write(await Html.PartialAsync("_noproduct"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\memo\OneDrive\Masaüstü\ShopApp\ShopApp\Views\Product\List.cshtml"
                                          
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n");
#nullable restore
#line 22 "C:\Users\memo\OneDrive\Masaüstü\ShopApp\ShopApp\Views\Product\List.cshtml"
         foreach (var product in products)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-4\">\r\n                ");
#nullable restore
#line 25 "C:\Users\memo\OneDrive\Masaüstü\ShopApp\ShopApp\Views\Product\List.cshtml"
           Write(await Html.PartialAsync("_product", product));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 27 "C:\Users\memo\OneDrive\Masaüstü\ShopApp\ShopApp\Views\Product\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 29 "C:\Users\memo\OneDrive\Masaüstü\ShopApp\ShopApp\Views\Product\List.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
