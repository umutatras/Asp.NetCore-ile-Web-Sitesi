#pragma checksum "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\FeatureList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a578eca9fd47f2659a04996f8926c8309feec538"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_FeatureList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/FeatureList/Default.cshtml")]
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
#line 1 "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\FeatureList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a578eca9fd47f2659a04996f8926c8309feec538", @"/Views/Shared/Components/FeatureList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_FeatureList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Feature>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<header>
  <div class=""cover bg-light"">
    <div class=""container px-3"">
      <div class=""row"">
        <div class=""col-lg-6 p-2""><img class=""img-fluid"" src=""/Template/images/illustrations/hello3.svg"" alt=""hello""/></div>
        <div class=""col-lg-6"">
");
#nullable restore
#line 9 "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\FeatureList\Default.cshtml"
             foreach(var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("          <div class=\"mt-5\">\r\n            <p class=\"lead text-uppercase mb-1\">");
#nullable restore
#line 11 "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\FeatureList\Default.cshtml"
                                           Write(item.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <h1 class=\"intro-title marker\" data-aos=\"fade-left\" data-aos-delay=\"50\">");
#nullable restore
#line 12 "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\FeatureList\Default.cshtml"
                                                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <p class=\"lead fw-normal mt-3\" data-aos=\"fade-up\" data-aos-delay=\"100\">");
#nullable restore
#line 13 "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\FeatureList\Default.cshtml"
                                                                              Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            ");
#nullable restore
#line 14 "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\FeatureList\Default.cshtml"
       Write(await Component.InvokeAsync("SocialMediaList"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n            <div class=\"mt-3\" data-aos=\"fade-up\" data-aos-delay=\"200\"><a class=\"btn btn-primary shadow-sm mt-1 hover-effect\" href=\"#contact\">Bana ulaşın! <i class=\"fas fa-arrow-right\"></i></a></div>\r\n          </div>\r\n");
#nullable restore
#line 17 "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\FeatureList\Default.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n      </div>\r\n    </div>\r\n  </div>\r\n  <div class=\"wave-bg\"></div>\r\n</header>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Feature>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591