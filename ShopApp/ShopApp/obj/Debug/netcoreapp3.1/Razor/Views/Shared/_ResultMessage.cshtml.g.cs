#pragma checksum "C:\Users\memo\OneDrive\Masaüstü\ShopApp\ShopApp\Views\Shared\_ResultMessage.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ff87e08433e45725cae5e85cf468a475546a223607393e11c1ded3a10f317c24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ResultMessage), @"mvc.1.0.view", @"/Views/Shared/_ResultMessage.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\Users\memo\OneDrive\Masaüstü\ShopApp\ShopApp\Views\_ViewImports.cshtml"
using ShopApp.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\memo\OneDrive\Masaüstü\ShopApp\ShopApp\Views\_ViewImports.cshtml"
using ShopApp.Models;

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
using ShopApp.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\memo\OneDrive\Masaüstü\ShopApp\ShopApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\memo\OneDrive\Masaüstü\ShopApp\ShopApp\Views\_ViewImports.cshtml"
using ShopApp.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"ff87e08433e45725cae5e85cf468a475546a223607393e11c1ded3a10f317c24", @"/Views/Shared/_ResultMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"6314d6801b66e25f481f63e0d7a2ab7f72b0d25a1eb3b139fc6d8533f3354dc3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__ResultMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AlertMessage>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-md-12\">\n        <div");
            BeginWriteAttribute("class", " class=\"", 79, "\"", 115, 3);
            WriteAttributeValue("", 87, "alert", 87, 5, true);
            WriteAttributeValue(" ", 92, "alert-", 93, 7, true);
#nullable restore
#line 5 "C:\Users\memo\OneDrive\Masaüstü\ShopApp\ShopApp\Views\Shared\_ResultMessage.cshtml"
WriteAttributeValue("", 99, Model.AlertType, 99, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n            <h4 class=\"alert-title\">");
#nullable restore
#line 6 "C:\Users\memo\OneDrive\Masaüstü\ShopApp\ShopApp\Views\Shared\_ResultMessage.cshtml"
                               Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n            <p>");
#nullable restore
#line 7 "C:\Users\memo\OneDrive\Masaüstü\ShopApp\ShopApp\Views\Shared\_ResultMessage.cshtml"
          Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AlertMessage> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
