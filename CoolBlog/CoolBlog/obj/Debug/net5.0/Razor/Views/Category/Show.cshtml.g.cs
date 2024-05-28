#pragma checksum "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Category\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bea8dc4079c29968b0f1857ae27080f81c2eb22"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Show), @"mvc.1.0.view", @"/Views/Category/Show.cshtml")]
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
#line 1 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\_ViewImports.cshtml"
using CoolBlog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\_ViewImports.cshtml"
using CoolBlog.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bea8dc4079c29968b0f1857ae27080f81c2eb22", @"/Views/Category/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bb7e9af37482eebe245178324533c8c1be311a5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Category_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Category\Show.cshtml"
  
    ViewData["Title"] = "Show";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"site-section\">\r\n      <div class=\"container\">\r\n        <div class=\"row mb-4\">\r\n          <div class=\"col-md-6\">\r\n            <h2 class=\"mb-4\">Category: ");
#nullable restore
#line 11 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Category\Show.cshtml"
                                  Write(ViewBag.categoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n          </div>\r\n        </div>\r\n        <div class=\"row blog-entries\">\r\n          <div class=\"col-md-12 col-lg-8 main-content\">\r\n            <div class=\"row mb-5 mt-5\">\r\n\r\n              <div class=\"col-md-12\">\r\n\r\n");
#nullable restore
#line 20 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Category\Show.cshtml"
                 foreach (var item in Model)
               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                   <div class=\"post-entry-horzontal\">\r\n                  <a");
            BeginWriteAttribute("href", " href=\"", 656, "\"", 694, 2);
            WriteAttributeValue("", 663, "Category/Index/", 663, 15, true);
#nullable restore
#line 23 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Category\Show.cshtml"
WriteAttributeValue("", 678, item.CategoryId, 678, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"image element-animate\" data-animate-effect=\"fadeIn\"");
            BeginWriteAttribute("style", " style=\"", 781, "\"", 828, 4);
            WriteAttributeValue("", 789, "background-image:", 789, 17, true);
            WriteAttributeValue(" ", 806, "url(", 807, 5, true);
#nullable restore
#line 24 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Category\Show.cshtml"
WriteAttributeValue("", 811, item.BlogImage, 811, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 826, ");", 826, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                    <span class=\"text\">\r\n                      <div class=\"post-meta\">\r\n                        <span class=\"category\">");
#nullable restore
#line 27 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Category\Show.cshtml"
                                          Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <span class=\"mr-2\">");
#nullable restore
#line 28 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Category\Show.cshtml"
                                      Write(item.BlogCreateDate.ToString().Substring(0,10));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> &bullet;\r\n                        <span class=\"ml-2\"><span class=\"fa fa-comments\"></span></span>\r\n                      </div>\r\n                      <h2>");
#nullable restore
#line 31 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Category\Show.cshtml"
                     Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    </span>\r\n                  </a>\r\n                </div>\n");
#nullable restore
#line 35 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Category\Show.cshtml"
               }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n              </div>\r\n            </div>\r\n\r\n            \r\n\r\n            \r\n\r\n          </div>\r\n\r\n          <!-- END main-content -->\r\n\r\n          \r\n          <!-- END sidebar -->\r\n\r\n        </div>\r\n      </div>\r\n    </section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591