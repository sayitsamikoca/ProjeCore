#pragma checksum "C:\Users\sayit\source\repos\ProjeCore\ProjeCore\Views\Birim\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "147ef4fc08a8f07e30ed52bcdd2da16760101ce7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Birim_Index), @"mvc.1.0.view", @"/Views/Birim/Index.cshtml")]
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
#line 1 "C:\Users\sayit\source\repos\ProjeCore\ProjeCore\Views\_ViewImports.cshtml"
using ProjeCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\sayit\source\repos\ProjeCore\ProjeCore\Views\Birim\Index.cshtml"
using ProjeCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"147ef4fc08a8f07e30ed52bcdd2da16760101ce7", @"/Views/Birim/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f6887fc2a081498e457a98abd035f4ecf5faaf7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Birim_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Birim>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\sayit\source\repos\ProjeCore\ProjeCore\Views\Birim\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_TestLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Birim</th>\r\n        <th>Sil</th>\r\n        <th>Güncelle</th>\r\n        <th>Detaylar</th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 20 "C:\Users\sayit\source\repos\ProjeCore\ProjeCore\Views\Birim\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\sayit\source\repos\ProjeCore\ProjeCore\Views\Birim\Index.cshtml"
           Write(item.BirimID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\sayit\source\repos\ProjeCore\ProjeCore\Views\Birim\Index.cshtml"
           Write(item.BirimAd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 478, "\"", 514, 2);
            WriteAttributeValue("", 485, "/Birim/BirimSil/", 485, 16, true);
#nullable restore
#line 25 "C:\Users\sayit\source\repos\ProjeCore\ProjeCore\Views\Birim\Index.cshtml"
WriteAttributeValue("", 501, item.BirimID, 501, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 571, "\"", 609, 2);
            WriteAttributeValue("", 578, "/Birim/BirimGetir/", 578, 18, true);
#nullable restore
#line 26 "C:\Users\sayit\source\repos\ProjeCore\ProjeCore\Views\Birim\Index.cshtml"
WriteAttributeValue("", 596, item.BirimID, 596, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Güncelle</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 672, "\"", 710, 2);
            WriteAttributeValue("", 679, "/Birim/BirimDetay/", 679, 18, true);
#nullable restore
#line 27 "C:\Users\sayit\source\repos\ProjeCore\ProjeCore\Views\Birim\Index.cshtml"
WriteAttributeValue("", 697, item.BirimID, 697, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Detaylar</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 29 "C:\Users\sayit\source\repos\ProjeCore\ProjeCore\Views\Birim\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<a href=\"/Birim/YeniBirim/\" class=\"btn btn-primary\">Yeni Birim</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Birim>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
