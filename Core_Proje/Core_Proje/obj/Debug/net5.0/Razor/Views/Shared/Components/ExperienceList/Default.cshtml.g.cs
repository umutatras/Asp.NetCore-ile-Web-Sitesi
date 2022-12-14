#pragma checksum "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\ExperienceList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6030e43f2ef6db925f48ee8bed02ab87504ae645"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ExperienceList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ExperienceList/Default.cshtml")]
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
#line 1 "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\ExperienceList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6030e43f2ef6db925f48ee8bed02ab87504ae645", @"/Views/Shared/Components/ExperienceList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_ExperienceList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Experience>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"section px-3 px-lg-4 pt-5\" id=\"experience\">\r\n  <div class=\"container-narrow\">\r\n    <div class=\"text-center mb-5\">\r\n      <h2 class=\"marker marker-center\">Deneyimler</h2>\r\n    </div>\r\n    <div class=\"row\">\r\n      <div class=\"col-md-12\">\r\n");
#nullable restore
#line 11 "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\ExperienceList\Default.cshtml"
           foreach(var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card mb-3\" data-aos=\"fade-right\" data-aos-delay=\"100\">\r\n          <div class=\"card-header px-3 py-2\">\r\n            <div class=\"d-flex justify-content-between\">\r\n              <div>\r\n                <h3 class=\"h5 mb-1\">");
#nullable restore
#line 16 "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\ExperienceList\Default.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <div class=\"text-muted text-small\"> ");
#nullable restore
#line 17 "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\ExperienceList\Default.cshtml"
                                               Write(Convert.ToDateTime(@item.Date).ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n              </div><img");
            BeginWriteAttribute("src", " src=\"", 735, "\"", 755, 1);
#nullable restore
#line 18 "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\ExperienceList\Default.cshtml"
WriteAttributeValue("", 741, item.ImageUrl, 741, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"48\" height=\"48\" alt=\"ui-ux\"/>\r\n            </div>\r\n          </div>\r\n          <div class=\"card-body px-3 py-2\">\r\n            <p>");
#nullable restore
#line 22 "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\ExperienceList\Default.cshtml"
          Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n          </div>\r\n        </div>");
#nullable restore
#line 24 "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\ExperienceList\Default.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </div>\r\n    </div>\r\n  </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Experience>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
