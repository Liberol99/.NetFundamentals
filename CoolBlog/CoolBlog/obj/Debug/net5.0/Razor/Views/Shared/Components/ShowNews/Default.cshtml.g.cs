#pragma checksum "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Shared\Components\ShowNews\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea069b90cc0395bd3e01a581eb9661e83d3cb940"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ShowNews_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ShowNews/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea069b90cc0395bd3e01a581eb9661e83d3cb940", @"/Views/Shared/Components/ShowNews/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bb7e9af37482eebe245178324533c8c1be311a5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_ShowNews_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Shared\Components\ShowNews\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"owl-carousel owl-theme home-slider\">\r\n              <div>\r\n                <a href=\"#\" class=\"a-block d-flex align-items-center height-lg\"");
            BeginWriteAttribute("style", " style=\"", 177, "\"", 224, 4);
            WriteAttributeValue("", 185, "background-image:", 185, 17, true);
            WriteAttributeValue(" ", 202, "url(", 203, 5, true);
#nullable restore
#line 6 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Shared\Components\ShowNews\Default.cshtml"
WriteAttributeValue("", 207, ViewBag.value2, 207, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 222, ");", 222, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                  <div class=\"text half-to-full\">\r\n                    <div class=\"post-meta\">\r\n                      <span class=\"category\">Teknoloji</span>\r\n                      <span class=\"mr-2\">");
#nullable restore
#line 10 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Shared\Components\ShowNews\Default.cshtml"
                                    Write(DateTime.Now.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 10 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Shared\Components\ShowNews\Default.cshtml"
                                                      Write(DateTime.Now.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 10 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Shared\Components\ShowNews\Default.cshtml"
                                                                          Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> &bullet;\r\n                      <span class=\"ml-2\"><span class=\"fa fa-comments\"></span></span>\r\n                    </div>\r\n                    <h3>");
#nullable restore
#line 13 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Shared\Components\ShowNews\Default.cshtml"
                   Write(ViewBag.value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p>");
#nullable restore
#line 14 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Shared\Components\ShowNews\Default.cshtml"
                  Write(ViewBag.value3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                  </div>\r\n                </a>\r\n              </div>\r\n              <div>\r\n                <a href=\"#\" class=\"a-block d-flex align-items-center height-lg\"");
            BeginWriteAttribute("style", " style=\"", 875, "\"", 923, 5);
            WriteAttributeValue("", 883, "background-image:", 883, 17, true);
            WriteAttributeValue(" ", 900, "url(", 901, 5, true);
#nullable restore
#line 19 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Shared\Components\ShowNews\Default.cshtml"
WriteAttributeValue("", 905, ViewBag.value5, 905, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 920, ");", 920, 2, true);
            WriteAttributeValue(" ", 922, "", 923, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                  <div class=\"text half-to-full\">\r\n                    <div class=\"post-meta\">\r\n                      <span class=\"category\">Teknoloji</span>\r\n                      <span class=\"mr-2\">");
#nullable restore
#line 23 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Shared\Components\ShowNews\Default.cshtml"
                                    Write(DateTime.Now.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 23 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Shared\Components\ShowNews\Default.cshtml"
                                                      Write(DateTime.Now.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 23 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Shared\Components\ShowNews\Default.cshtml"
                                                                          Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> &bullet;\r\n                      <span class=\"ml-2\"><span class=\"fa fa-comments\"></span></span>\r\n                    </div>\r\n                    <h3>");
#nullable restore
#line 26 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Shared\Components\ShowNews\Default.cshtml"
                   Write(ViewBag.value4);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p>");
#nullable restore
#line 27 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Shared\Components\ShowNews\Default.cshtml"
                  Write(ViewBag.value6);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                  </div>\r\n                </a>\r\n              </div>\r\n              <div>\r\n                <a href=\"#\" class=\"a-block d-flex align-items-center height-lg\"");
            BeginWriteAttribute("style", " style=\"", 1575, "\"", 1623, 5);
            WriteAttributeValue("", 1583, "background-image:", 1583, 17, true);
            WriteAttributeValue(" ", 1600, "url(", 1601, 5, true);
#nullable restore
#line 32 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Shared\Components\ShowNews\Default.cshtml"
WriteAttributeValue("", 1605, ViewBag.value8, 1605, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1620, ");", 1620, 2, true);
            WriteAttributeValue(" ", 1622, "", 1623, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                  <div class=\"text half-to-full\">\r\n                    <div class=\"post-meta\">\r\n                      <span class=\"category\">Teknoloji</span>\r\n                      <span class=\"mr-2\">");
#nullable restore
#line 36 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Shared\Components\ShowNews\Default.cshtml"
                                    Write(DateTime.Now.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 36 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Shared\Components\ShowNews\Default.cshtml"
                                                      Write(DateTime.Now.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 36 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Shared\Components\ShowNews\Default.cshtml"
                                                                          Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> &bullet;\r\n                      <span class=\"ml-2\"><span class=\"fa fa-comments\"></span></span>\r\n                    </div>\r\n                    <h3>");
#nullable restore
#line 39 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Shared\Components\ShowNews\Default.cshtml"
                   Write(ViewBag.value7);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p>");
#nullable restore
#line 40 "C:\Users\orkan\source\repos\CoolBlog\CoolBlog\Views\Shared\Components\ShowNews\Default.cshtml"
                  Write(ViewBag.value9);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                  </div>\r\n                </a>\r\n              </div>\r\n            </div>");
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
