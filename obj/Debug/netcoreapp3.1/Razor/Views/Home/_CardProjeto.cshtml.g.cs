#pragma checksum "C:\Users\Fabrício\Documents\repositorio local git\IdSoftware\Views\Home\_CardProjeto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b605c9dc730c3df77225b9bd998d4bf054ff46f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__CardProjeto), @"mvc.1.0.view", @"/Views/Home/_CardProjeto.cshtml")]
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
#line 1 "C:\Users\Fabrício\Documents\repositorio local git\IdSoftware\Views\_ViewImports.cshtml"
using IdSoftware;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fabrício\Documents\repositorio local git\IdSoftware\Views\_ViewImports.cshtml"
using IdSoftware.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b605c9dc730c3df77225b9bd998d4bf054ff46f2", @"/Views/Home/_CardProjeto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d87ec58aed00bcc1afb22fe2a82f86a64786bbdc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__CardProjeto : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("  <div class=\"card\">\r\n      <div class=\"card-img\">\r\n          <img");
            BeginWriteAttribute("src", " src=", 78, "", 83, 0);
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 4 "C:\Users\Fabrício\Documents\repositorio local git\IdSoftware\Views\Home\_CardProjeto.cshtml"
                Write("/images/projeto" + @Model + ".png");

#line default
#line hidden
#nullable disable
            WriteLiteral(" class=\"img-fluid\">\r\n      </div>\r\n      \r\n      <div class=\"card-body\">\r\n      <h4 class=\"card-title\">Projeto ");
#nullable restore
#line 8 "C:\Users\Fabrício\Documents\repositorio local git\IdSoftware\Views\Home\_CardProjeto.cshtml"
                                Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(" da ID</h4>\r\n          <p class=\"card-text\">In hac habitasse platea dictumst. Suspendisse mattis mattis semper.</p>\r\n      </div>\r\n      <div class=\"card-footer\">\r\n          <a");
            BeginWriteAttribute("href", " href=\"", 415, "\"", 422, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"card-link\">Saiba Mais</a>\r\n      </div>\r\n  </div>\r\n           ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
