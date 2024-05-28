#pragma checksum "C:\Users\Shelby\Documents\MvcProjeler\CoolErp\CoolErp\Views\Category\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14d9aac816199e6637195210ee7d46dc0b8c7cf0"
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
#line 1 "C:\Users\Shelby\Documents\MvcProjeler\CoolErp\CoolErp\Views\_ViewImports.cshtml"
using CoolErp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shelby\Documents\MvcProjeler\CoolErp\CoolErp\Views\_ViewImports.cshtml"
using CoolErp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14d9aac816199e6637195210ee7d46dc0b8c7cf0", @"/Views/Category/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54c344df7f31eae069ee3891e3b44701dcaa1e9c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Category_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EntityLayer.Concrete.Category>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Shelby\Documents\MvcProjeler\CoolErp\CoolErp\Views\Category\Show.cshtml"
  
    ViewData["Title"] = "Show";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
                            <div class=""col-lg-12"">
                                <div class=""row"">
                                    <div class=""col-md-12  d-flex flex-row align-items-center"">
                                    <h2 class=""title-1 mb-2 mr-3 ml-2"">Kategori Kartı Listesi</h2>
                                    <a class=""btn btn-success mb-2"" href=""/Category/Add"">Kategori Ekle</a>
                                    </div>
                                </div>
                                <div class=""table-responsive table--no-card m-b-40"">
                                    <table class=""table table-borderless table-striped table-earning"">
                                        <thead>
                                            <tr>
                                                <th>Category Name</th>
                                                <th>Description</th>
                                                <th>Picture</th>
             ");
            WriteLiteral(@"                                   <th class=""text-right"">Kategori Güncelle</th>
                                                <th class=""text-right"">Kategori Sil</th>
                                            </tr>
                                        </thead>
                                        <tbody>
");
#nullable restore
#line 27 "C:\Users\Shelby\Documents\MvcProjeler\CoolErp\CoolErp\Views\Category\Show.cshtml"
                                             foreach(var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td>");
#nullable restore
#line 29 "C:\Users\Shelby\Documents\MvcProjeler\CoolErp\CoolErp\Views\Category\Show.cshtml"
                                               Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 30 "C:\Users\Shelby\Documents\MvcProjeler\CoolErp\CoolErp\Views\Category\Show.cshtml"
                                               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td><img");
            BeginWriteAttribute("src", " src=\"", 1810, "\"", 1829, 1);
#nullable restore
#line 31 "C:\Users\Shelby\Documents\MvcProjeler\CoolErp\CoolErp\Views\Category\Show.cshtml"
WriteAttributeValue("", 1816, item.Picture, 1816, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>    \r\n                                                <td class=\"text-right\"><a class=\"btn btn-warning\"");
            BeginWriteAttribute("href", " href=\"", 1941, "\"", 1981, 2);
            WriteAttributeValue("", 1948, "/Category/Update/", 1948, 17, true);
#nullable restore
#line 32 "C:\Users\Shelby\Documents\MvcProjeler\CoolErp\CoolErp\Views\Category\Show.cshtml"
WriteAttributeValue("", 1965, item.CategoryId, 1965, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Güncelle</a></td>\r\n                                                <td class=\"text-right\"><a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 2098, "\"", 2138, 2);
            WriteAttributeValue("", 2105, "/Category/Delete/", 2105, 17, true);
#nullable restore
#line 33 "C:\Users\Shelby\Documents\MvcProjeler\CoolErp\CoolErp\Views\Category\Show.cshtml"
WriteAttributeValue("", 2122, item.CategoryId, 2122, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sil</a></td>\r\n                                            </tr>\r\n");
#nullable restore
#line 35 "C:\Users\Shelby\Documents\MvcProjeler\CoolErp\CoolErp\Views\Category\Show.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </tbody>\r\n                                    </table>\r\n                                </div>\r\n                            </div>\r\n                        </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EntityLayer.Concrete.Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591