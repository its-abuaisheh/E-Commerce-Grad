#pragma checksum "C:\Users\laith\Desktop\E-Commerce\E-Commerce\Areas\Admin\Views\Home\ShowMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c62b61b2765471cff1929a069607d17914154cdb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_ShowMessage), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/ShowMessage.cshtml")]
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
#line 1 "C:\Users\laith\Desktop\E-Commerce\E-Commerce\Areas\Admin\Views\_ViewImports.cshtml"
using E_Commerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\laith\Desktop\E-Commerce\E-Commerce\Areas\Admin\Views\_ViewImports.cshtml"
using E_Commerce.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c62b61b2765471cff1929a069607d17914154cdb", @"/Areas/Admin/Views/Home/ShowMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f015392c42bf201d3f4fa8f785de821ea8cb926", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Home_ShowMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Contact>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section class=""content"">
    <div class=""container-fluid"">

        <div class=""row"">
            <div class=""col-12"">
                <div class=""card"">
                    <div class=""card-header"">

                        <div class=""card-body table-responsive p-0"" style=""height: 300px;"">
                            <table class=""table table-head-fixed"">
                                <thead>
                                    <tr>
                                        <th>Name</th>
                                        <th>Email</th>
                                        <th>Subject</th>
                                        <th>Message</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 22 "C:\Users\laith\Desktop\E-Commerce\E-Commerce\Areas\Admin\Views\Home\ShowMessage.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 25 "C:\Users\laith\Desktop\E-Commerce\E-Commerce\Areas\Admin\Views\Home\ShowMessage.cshtml"
                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 26 "C:\Users\laith\Desktop\E-Commerce\E-Commerce\Areas\Admin\Views\Home\ShowMessage.cshtml"
                                           Write(item.UserEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 27 "C:\Users\laith\Desktop\E-Commerce\E-Commerce\Areas\Admin\Views\Home\ShowMessage.cshtml"
                                           Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 28 "C:\Users\laith\Desktop\E-Commerce\E-Commerce\Areas\Admin\Views\Home\ShowMessage.cshtml"
                                           Write(item.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n                                        </tr>\r\n");
#nullable restore
#line 32 "C:\Users\laith\Desktop\E-Commerce\E-Commerce\Areas\Admin\Views\Home\ShowMessage.cshtml"

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                </tbody>\r\n                            </table>\r\n                        </div>\r\n\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Contact>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591