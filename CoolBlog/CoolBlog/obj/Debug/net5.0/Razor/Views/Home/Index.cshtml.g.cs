#pragma checksum "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adf04e67ca4c0c384b92bb4d4af677030a863dcd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Home\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Home\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adf04e67ca4c0c384b92bb4d4af677030a863dcd", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bb7e9af37482eebe245178324533c8c1be311a5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 10 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Home\Index.cshtml"
       Write(await Component.InvokeAsync("ShowNews"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            \r\n          </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            ");
#nullable restore
#line 15 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Home\Index.cshtml"
       Write(await Component.InvokeAsync("ShowNewsBottom"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
      </div>


    </section>
    <!-- END section -->

    <section class=""site-section py-sm"">
      <div class=""container"">
        <div class=""row"">
          <div class=""col-md-6"">
            <h2 class=""mb-4"">Genel Haberler</h2>
          </div>
        </div>
        <div class=""row blog-entries"">
          <div class=""col-md-12 col-lg-8 main-content"">
            <div class=""row"">
");
#nullable restore
#line 33 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Home\Index.cshtml"
               foreach (var item in Model)
             {

#line default
#line hidden
#nullable disable
            WriteLiteral("                 <div class=\"col-md-6\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 900, "\"", 934, 2);
            WriteAttributeValue("", 907, "Category/Index/", 907, 15, true);
#nullable restore
#line 36 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Home\Index.cshtml"
WriteAttributeValue("", 922, item.BlogId, 922, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"blog-entry element-animate\" data-animate-effect=\"fadeIn\">\r\n                  <img");
            BeginWriteAttribute("src", " src=\"", 1024, "\"", 1045, 1);
#nullable restore
#line 37 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Home\Index.cshtml"
WriteAttributeValue("", 1030, item.BlogImage, 1030, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Image placeholder\">\r\n                  <div class=\"blog-content-body\">\r\n                    <div class=\"post-meta\">\r\n                      <span class=\"category\">");
#nullable restore
#line 40 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Home\Index.cshtml"
                                        Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                      <span class=\"mr-2\">");
#nullable restore
#line 41 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Home\Index.cshtml"
                                    Write(item.BlogCreateDate.ToString().Substring(0,10));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span> &bullet;\r\n                      <span class=\"ml-2\"><span class=\"fa fa-comments\"></span> ");
#nullable restore
#line 42 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Home\Index.cshtml"
                                                                         Write(item.BlogContent.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                    <h2>");
#nullable restore
#line 44 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Home\Index.cshtml"
                   Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                  </div>\r\n                </a>\r\n              </div>\n");
#nullable restore
#line 48 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Home\Index.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n            <div class=\"row\">\r\n              <div class=\"col-md-12 text-center\">\r\n                  ");
#nullable restore
#line 53 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Home\Index.cshtml"
             Write(Html.PagedListPager((IPagedList)Model,page=>Url.Action("Index",new {page})));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n              </div>\r\n            </div>\r\n\r\n\r\n            <div class=\"row mb-5 mt-5\">\r\n\r\n              <div class=\"col-md-12\">\r\n                <h2 class=\"mb-4\">Daha Fazla Post</h2>\r\n              </div>\r\n                 ");
#nullable restore
#line 63 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Home\Index.cshtml"
            Write(await Component.InvokeAsync("ShowMoreBlogs"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>

            

          </div>

          <!-- END main-content -->

          <div class=""col-md-12 col-lg-4 sidebar"">
            
            <!-- END sidebar-box -->
            
            <!-- END sidebar-box -->  
            ");
#nullable restore
#line 77 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Home\Index.cshtml"
       Write(await Component.InvokeAsync("SideBarWriter"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <!-- END sidebar-box -->\r\n\r\n            \r\n            <!-- END sidebar-box -->\r\n\r\n            \r\n          </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591