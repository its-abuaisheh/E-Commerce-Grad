#pragma checksum "C:\Users\laith\Desktop\E-Commerce\E-Commerce\Views\Home\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ac221dc6be763b1797af7b2f5f3c5405633f54f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Search), @"mvc.1.0.view", @"/Views/Home/Search.cshtml")]
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
#line 1 "C:\Users\laith\Desktop\E-Commerce\E-Commerce\Views\_ViewImports.cshtml"
using E_Commerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\laith\Desktop\E-Commerce\E-Commerce\Views\_ViewImports.cshtml"
using E_Commerce.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\laith\Desktop\E-Commerce\E-Commerce\Views\_ViewImports.cshtml"
using Ecommerce.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ac221dc6be763b1797af7b2f5f3c5405633f54f", @"/Views/Home/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d2b66df2327a6d1f0a0595325780255837c4326", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark btn-square"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductDetailes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- Breadcrumb Start -->
<div class=""container-fluid"">
    <div class=""row px-xl-5"">
        <div class=""col-12"">
            <nav class=""breadcrumb bg-light mb-30"">
                <a class=""breadcrumb-item text-dark"" href=""#"">Home</a>
                <a class=""breadcrumb-item text-dark"" href=""#"">Shop</a>
                <span class=""breadcrumb-item active"">Shop List</span>
            </nav>
        </div>
    </div>
</div>
<!-- Breadcrumb End -->
<!-- Shop Start -->
<div class=""container-fluid"">
    <div class=""row px-xl-5"">



        <!-- Shop Product Start -->
        <div class=""col-lg-12 col-md-8"">
            <div class=""row pb-3"">
");
#nullable restore
#line 24 "C:\Users\laith\Desktop\E-Commerce\E-Commerce\Views\Home\Search.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-4 col-md-6 col-sm-6 pb-1\">\r\n                        <div class=\"product-item bg-light mb-4\">\r\n                            <div class=\"product-img position-relative overflow-hidden\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8ac221dc6be763b1797af7b2f5f3c5405633f54f6313", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1047, "~/Product/", 1047, 10, true);
#nullable restore
#line 29 "C:\Users\laith\Desktop\E-Commerce\E-Commerce\Views\Home\Search.cshtml"
AddHtmlAttributeValue("", 1057, item.ProductImage, 1057, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <div class=\"product-action\">\r\n                                    <a class=\"btn btn-outline-dark btn-square\"");
            BeginWriteAttribute("href", "\r\n                                       href=\"", 1226, "\"", 1310, 2);
            WriteAttributeValue("", 1273, "/Home/ProductDetailes/", 1273, 22, true);
#nullable restore
#line 32 "C:\Users\laith\Desktop\E-Commerce\E-Commerce\Views\Home\Search.cshtml"
WriteAttributeValue("", 1295, item.ProductID, 1295, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <i class=\"fa fa-search\"></i>\r\n                                    </a>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ac221dc6be763b1797af7b2f5f3c5405633f54f8747", async() => {
                WriteLiteral("\r\n                                        <i class=\"fa fa-shopping-cart\"></i>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"text-center py-4\">\r\n                                <a class=\"h6 text-decoration-none text-truncate\"");
            BeginWriteAttribute("href", " href=\"", 1935, "\"", 1942, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 44 "C:\Users\laith\Desktop\E-Commerce\E-Commerce\Views\Home\Search.cshtml"
                               Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </a>\r\n                                <div class=\"d-flex align-items-center justify-content-center mt-2\">\r\n                                    <h5>$");
#nullable restore
#line 47 "C:\Users\laith\Desktop\E-Commerce\E-Commerce\Views\Home\Search.cshtml"
                                    Write(item.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5><h6 class=\"text-muted ml-2\"></h6>\r\n                                </div>\r\n\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 53 "C:\Users\laith\Desktop\E-Commerce\E-Commerce\Views\Home\Search.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                <div class=\"col-12\">\r\n                    <nav>\r\n                        <ul class=\"pagination justify-content-center\">\r\n");
#nullable restore
#line 60 "C:\Users\laith\Desktop\E-Commerce\E-Commerce\Views\Home\Search.cshtml"
                             if (ViewBag.CurrentPage - 1 > 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"page-item\">\r\n                                    <a class=\"page-link\"");
            BeginWriteAttribute("href", "\r\n                                       href=\"", 2745, "\"", 2842, 2);
            WriteAttributeValue("", 2792, "/Home/Product/?pagenumber=", 2792, 26, true);
#nullable restore
#line 64 "C:\Users\laith\Desktop\E-Commerce\E-Commerce\Views\Home\Search.cshtml"
WriteAttributeValue("", 2818, ViewBag.PageCount - 1, 2818, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        Previous\r\n                                    </a>\r\n                                </li>\r\n");
#nullable restore
#line 68 "C:\Users\laith\Desktop\E-Commerce\E-Commerce\Views\Home\Search.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\laith\Desktop\E-Commerce\E-Commerce\Views\Home\Search.cshtml"
                             if (ViewBag.CurrentPage + 1 <= ViewBag.PageCount)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"page-item \">\r\n\r\n\r\n                                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3236, "\"", 3294, 2);
            WriteAttributeValue("", 3243, "/Home/Product/?pagenumber=", 3243, 26, true);
#nullable restore
#line 74 "C:\Users\laith\Desktop\E-Commerce\E-Commerce\Views\Home\Search.cshtml"
WriteAttributeValue("", 3269, ViewBag.CurrentPage +1, 3269, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Next</a>\r\n                                </li>\r\n");
#nullable restore
#line 76 "C:\Users\laith\Desktop\E-Commerce\E-Commerce\Views\Home\Search.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                        </ul>\r\n                    </nav>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <!-- Shop Product End -->\r\n    </div>\r\n</div>\r\n<!-- Shop End -->");
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
