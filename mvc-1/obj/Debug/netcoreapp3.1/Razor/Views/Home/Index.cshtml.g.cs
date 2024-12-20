#pragma checksum "C:\Users\girman\source\repos\mvc-1\mvc-1\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "de3151ac94216f5f576ac46b97a8a65c3b72f28881484cec86c254ed15ef21e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCoreGeneratedDocument
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\girman\source\repos\mvc-1\mvc-1\Views\_ViewImports.cshtml"
using mvc_1

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\girman\source\repos\mvc-1\mvc-1\Views\_ViewImports.cshtml"
using mvc_1.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"de3151ac94216f5f576ac46b97a8a65c3b72f28881484cec86c254ed15ef21e6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"3a9bf26c9b44f73402cbf6a064a61bb6fe6941451c2cdb22ae26eb2ea20cde88", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 1 "C:\Users\girman\source\repos\mvc-1\mvc-1\Views\Home\Index.cshtml"
       List<Product>

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Product List</h1>\r\n<a href=\"/Home/Create\">Create New Product</a>\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <th>Name</th>\r\n            <th>Price</th>\r\n            <th>Actions</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 14 "C:\Users\girman\source\repos\mvc-1\mvc-1\Views\Home\Index.cshtml"
         foreach (var product in Model)
        {

#line default
#line hidden
#nullable disable

            WriteLiteral("            <tr>\r\n                <td>");
            Write(
#nullable restore
#line 17 "C:\Users\girman\source\repos\mvc-1\mvc-1\Views\Home\Index.cshtml"
                     product.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                <td>");
            Write(
#nullable restore
#line 18 "C:\Users\girman\source\repos\mvc-1\mvc-1\Views\Home\Index.cshtml"
                     product.Price

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                <td>\r\n\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 454, "\"", 486, 2);
            WriteAttributeValue("", 461, "/Home/Details/", 461, 14, true);
            WriteAttributeValue("", 475, 
#nullable restore
#line 21 "C:\Users\girman\source\repos\mvc-1\mvc-1\Views\Home\Index.cshtml"
                                            product.Id

#line default
#line hidden
#nullable disable
            , 475, 11, false);
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 525, "\"", 554, 2);
            WriteAttributeValue("", 532, "/Home/Edit/", 532, 11, true);
            WriteAttributeValue("", 543, 
#nullable restore
#line 22 "C:\Users\girman\source\repos\mvc-1\mvc-1\Views\Home\Index.cshtml"
                                         product.Id

#line default
#line hidden
#nullable disable
            , 543, 11, false);
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 590, "\"", 621, 2);
            WriteAttributeValue("", 597, "/Home/Delete/", 597, 13, true);
            WriteAttributeValue("", 610, 
#nullable restore
#line 23 "C:\Users\girman\source\repos\mvc-1\mvc-1\Views\Home\Index.cshtml"
                                           product.Id

#line default
#line hidden
#nullable disable
            , 610, 11, false);
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 26 "C:\Users\girman\source\repos\mvc-1\mvc-1\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable

            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
