#pragma checksum "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Shared\Components\SideBarWriter\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bab9ceb34edfe18c60f25848ec7d6437263a18e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SideBarWriter_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SideBarWriter/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bab9ceb34edfe18c60f25848ec7d6437263a18e", @"/Views/Shared/Components/SideBarWriter/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bb7e9af37482eebe245178324533c8c1be311a5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_SideBarWriter_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"sidebar-box\">\r\n              <h3 class=\"heading\">Yazarlarımız</h3>\r\n              <div class=\"post-entry-sidebar\">\r\n                <ul>\r\n");
#nullable restore
#line 5 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Shared\Components\SideBarWriter\Default.cshtml"
                   foreach (var item in Model)
                 {

#line default
#line hidden
#nullable disable
            WriteLiteral("                     <li>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 267, "\"", 274, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                      <img");
            BeginWriteAttribute("src", " src=\"", 304, "\"", 327, 1);
#nullable restore
#line 9 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Shared\Components\SideBarWriter\Default.cshtml"
WriteAttributeValue("", 310, item.WriterImage, 310, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Image placeholder\" class=\"mr-4\">\r\n                      <div class=\"text\">\r\n                        <h4>");
#nullable restore
#line 11 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Shared\Components\SideBarWriter\Default.cshtml"
                       Write(item.WriterAbout);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <div class=\"post-meta\">\r\n                          <span class=\"mr-2\">");
#nullable restore
#line 13 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Shared\Components\SideBarWriter\Default.cshtml"
                                        Write(item.WriterMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> &bullet;<br>\r\n                          <span class=\"ml-2\"><span class=\"fa fa-comments mr-2\"></span></span>\r\n                        </div>\r\n                      </div>\r\n                    </a>\r\n                  </li>\r\n");
#nullable restore
#line 19 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Shared\Components\SideBarWriter\Default.cshtml"
                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n              </div>\r\n            </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591