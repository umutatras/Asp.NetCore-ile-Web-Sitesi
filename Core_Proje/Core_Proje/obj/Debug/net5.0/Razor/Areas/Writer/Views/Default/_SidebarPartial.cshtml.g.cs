#pragma checksum "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Areas\Writer\Views\Default\_SidebarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f59b85b7d1f44b57d8a92b89e7722198636833fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Default__SidebarPartial), @"mvc.1.0.view", @"/Areas/Writer/Views/Default/_SidebarPartial.cshtml")]
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
#line 1 "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Areas\Writer\Views\_ViewImports.cshtml"
using Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Areas\Writer\Views\_ViewImports.cshtml"
using Core_Proje.Areas.Writer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f59b85b7d1f44b57d8a92b89e7722198636833fd", @"/Areas/Writer/Views/Default/_SidebarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52fffa1682fad71c72e9150bb9185e0e79a12862", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Writer_Views_Default__SidebarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<nav class=""sidebar sidebar-offcanvas"" id=""sidebar"">
 
    <ul class=""nav"">
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/Dashboard/Index/"">
                <i class=""icon-grid menu-icon""></i>
                <span class=""menu-title"">Dashboard</span>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/Default/Index/"">
                <i class=""icon-grid menu-icon""></i>
                <span class=""menu-title"">Duyurular</span>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/Profil/Index/"">
                <i class=""icon-grid menu-icon""></i>
                <span class=""menu-title"">Profil</span>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/Message/Index/"">
                <i class=""icon-grid menu-icon""></i>
                <span class=""menu-title"">Gelen Kutusu</span>
            </a>
            WriteLiteral(@"
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/Message/SenderMessage/"">
                <i class=""icon-grid menu-icon""></i>
                <span class=""menu-title"">Giden Kutusu</span>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/Message/AddMessage/"">
                <i class=""icon-grid menu-icon""></i>
                <span class=""menu-title"">Yeni Mesaj</span>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/Profil/Index/"">
                <i class=""icon-grid menu-icon""></i>
                <span class=""menu-title"">Ayarlar</span>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/Login/LogOut/"">
                <i class=""icon-grid menu-icon""></i>
                <span class=""menu-title"">Çıkış</span>
            </a>
        </li>
    </ul>

</nav>");
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