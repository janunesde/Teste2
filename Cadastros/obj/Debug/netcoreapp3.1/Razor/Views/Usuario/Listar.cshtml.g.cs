#pragma checksum "/root/websenac/uc004/Cadastros/Views/Usuario/Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c69424ec0ee65f9c8727dffe05b40225bb1129e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Listar), @"mvc.1.0.view", @"/Views/Usuario/Listar.cshtml")]
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
#line 1 "/root/websenac/uc004/Cadastros/Views/_ViewImports.cshtml"
using Cadastros;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/root/websenac/uc004/Cadastros/Views/_ViewImports.cshtml"
using Cadastros.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c69424ec0ee65f9c8727dffe05b40225bb1129e", @"/Views/Usuario/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bdb0dc22cfe52403a06683669d4e27c1c452006", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/root/websenac/uc004/Cadastros/Views/Usuario/Listar.cshtml"
  
    ViewData["Title"] = "Listagem de Usuário";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Listagem de Usuário</h2>\n<table>\n    <thead>\n        <tr>\n            <th>Id</th>\n            <th>Nome</th>\n            <th>Login</th>\n            <th>Senha</th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 17 "/root/websenac/uc004/Cadastros/Views/Usuario/Listar.cshtml"
         foreach (Usuario u in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 20 "/root/websenac/uc004/Cadastros/Views/Usuario/Listar.cshtml"
               Write(u.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 21 "/root/websenac/uc004/Cadastros/Views/Usuario/Listar.cshtml"
               Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 22 "/root/websenac/uc004/Cadastros/Views/Usuario/Listar.cshtml"
               Write(u.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 23 "/root/websenac/uc004/Cadastros/Views/Usuario/Listar.cshtml"
               Write(u.Senha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 25 "/root/websenac/uc004/Cadastros/Views/Usuario/Listar.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591