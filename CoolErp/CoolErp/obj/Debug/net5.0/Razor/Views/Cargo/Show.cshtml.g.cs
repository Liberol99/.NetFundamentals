#pragma checksum "C:\Users\Shelby\Documents\MvcProjeler\CoolErp\CoolErp\Views\Cargo\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "857225c5d4639e71f6d94dfc4f3690e96aabcf4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cargo_Show), @"mvc.1.0.view", @"/Views/Cargo/Show.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"857225c5d4639e71f6d94dfc4f3690e96aabcf4b", @"/Views/Cargo/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54c344df7f31eae069ee3891e3b44701dcaa1e9c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cargo_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Product>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cargo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success mt-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Shelby\Documents\MvcProjeler\CoolErp\CoolErp\Views\Cargo\Show.cshtml"
  
    ViewData["Title"] = "Show";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"jumbotron\" style=\"background-color:#E5E5E5\">\r\n\r\n<div");
            BeginWriteAttribute("class", " class=\"", 188, "\"", 196, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"alert\" style=\"background-color:#4272D7\" role=\"alert\">\r\n    <h1 class=\"text-white\">Firma Adı</h1>\r\n    <p class=\"text-white\">");
#nullable restore
#line 11 "C:\Users\Shelby\Documents\MvcProjeler\CoolErp\CoolErp\Views\Cargo\Show.cshtml"
                     Write(ViewBag.shipperName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <i class=""fa fa-truck"" aria-hidden=""true""></i></p>
    </div>

    
    <div class=""alert"" style=""background-color:#4272D7"" role=""alert"">
    <h1 class=""text-white"">Ürün Adı</h1>
    <div class=""d-flex flex-row justify-content-between"">
        <p class=""text-white"">");
#nullable restore
#line 18 "C:\Users\Shelby\Documents\MvcProjeler\CoolErp\CoolErp\Views\Cargo\Show.cshtml"
                         Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"text-white\">Kalan Stok : ");
#nullable restore
#line 19 "C:\Users\Shelby\Documents\MvcProjeler\CoolErp\CoolErp\Views\Cargo\Show.cshtml"
                                      Write(Model.UnitsInStock);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</pclass>
    </div>
    </div>

    
    <div class=""alert"" style=""background-color:#4272D7"" role=""alert"">
    <h1 class=""text-white"">Adres Girin</h1>
    <textarea class=""form-control"" style=""min-height:150px!important"">
    </textarea>
    </div>

    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "857225c5d4639e71f6d94dfc4f3690e96aabcf4b6057", async() => {
                WriteLiteral("Gönder");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591