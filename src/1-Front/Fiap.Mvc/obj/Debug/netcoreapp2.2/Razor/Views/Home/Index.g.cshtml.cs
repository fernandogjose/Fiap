#pragma checksum "C:\MeusProjetos\Fiap\src\1-Front\Fiap.Mvc\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2f484a49eb2621a558462b49a59815e93732f07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2f484a49eb2621a558462b49a59815e93732f07", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Fiap.Domain.Entities.Receita>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\MeusProjetos\Fiap\src\1-Front\Fiap.Mvc\Views\Home\Index.cshtml"
  
    ViewBag.Title = "MasterChef";

#line default
#line hidden
            BeginContext(92, 29, true);
            WriteLiteral("<h2>Receita</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(122, 36, false);
#line 8 "C:\MeusProjetos\Fiap\src\1-Front\Fiap.Mvc\Views\Home\Index.cshtml"
Write(Html.ActionLink("Adicionar", "Novo"));

#line default
#line hidden
            EndContext();
            BeginContext(158, 91, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\" id=\"tblReceitas\">\r\n    <thead>\r\n        <tr>\r\n            <th>");
            EndContext();
            BeginContext(250, 40, false);
#line 13 "C:\MeusProjetos\Fiap\src\1-Front\Fiap.Mvc\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(290, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(314, 48, false);
#line 14 "C:\MeusProjetos\Fiap\src\1-Front\Fiap.Mvc\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TempoPreparo));

#line default
#line hidden
            EndContext();
            BeginContext(362, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(386, 53, false);
#line 15 "C:\MeusProjetos\Fiap\src\1-Front\Fiap.Mvc\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.QuantidadePessoas));

#line default
#line hidden
            EndContext();
            BeginContext(439, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(463, 40, false);
#line 16 "C:\MeusProjetos\Fiap\src\1-Front\Fiap.Mvc\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Tags));

#line default
#line hidden
            EndContext();
            BeginContext(503, 95, true);
            WriteLiteral("</th>\r\n            <th></th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 22 "C:\MeusProjetos\Fiap\src\1-Front\Fiap.Mvc\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(647, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(678, 39, false);
#line 25 "C:\MeusProjetos\Fiap\src\1-Front\Fiap.Mvc\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(717, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(741, 47, false);
#line 26 "C:\MeusProjetos\Fiap\src\1-Front\Fiap.Mvc\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TempoPreparo));

#line default
#line hidden
            EndContext();
            BeginContext(788, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(812, 52, false);
#line 27 "C:\MeusProjetos\Fiap\src\1-Front\Fiap.Mvc\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.QuantidadePessoas));

#line default
#line hidden
            EndContext();
            BeginContext(864, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(888, 39, false);
#line 28 "C:\MeusProjetos\Fiap\src\1-Front\Fiap.Mvc\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Tags));

#line default
#line hidden
            EndContext();
            BeginContext(927, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(951, 57, false);
#line 29 "C:\MeusProjetos\Fiap\src\1-Front\Fiap.Mvc\Views\Home\Index.cshtml"
           Write(Html.ActionLink("Editar", "Editar", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1008, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1032, 59, false);
#line 30 "C:\MeusProjetos\Fiap\src\1-Front\Fiap.Mvc\Views\Home\Index.cshtml"
           Write(Html.ActionLink("Deletar", "Deletar", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1091, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 32 "C:\MeusProjetos\Fiap\src\1-Front\Fiap.Mvc\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1124, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Fiap.Domain.Entities.Receita>> Html { get; private set; }
    }
}
#pragma warning restore 1591
