#pragma checksum "C:\Users\anton\Repositorio\ProjetoCRUD\Views\RegistroVendas\BuscaSimples.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad67d0223643197132c7afc0686f172d9d0c1702"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RegistroVendas_BuscaSimples), @"mvc.1.0.view", @"/Views/RegistroVendas/BuscaSimples.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RegistroVendas/BuscaSimples.cshtml", typeof(AspNetCore.Views_RegistroVendas_BuscaSimples))]
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
#line 1 "C:\Users\anton\Repositorio\ProjetoCRUD\Views\_ViewImports.cshtml"
using ProjetoVendas;

#line default
#line hidden
#line 2 "C:\Users\anton\Repositorio\ProjetoCRUD\Views\_ViewImports.cshtml"
using ProjetoVendas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad67d0223643197132c7afc0686f172d9d0c1702", @"/Views/RegistroVendas/BuscaSimples.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e86b0b057e7e3a073df2fd37bebe9b35bf20ad01", @"/Views/_ViewImports.cshtml")]
    public class Views_RegistroVendas_BuscaSimples : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjetoVendas.Models.RegistroVendas>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form navbar-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\anton\Repositorio\ProjetoCRUD\Views\RegistroVendas\BuscaSimples.cshtml"
  
    ViewData["Title"] = "Busca simples";

#line default
#line hidden
            BeginContext(108, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(115, 17, false);
#line 7 "C:\Users\anton\Repositorio\ProjetoCRUD\Views\RegistroVendas\BuscaSimples.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(132, 89, true);
            WriteLiteral("</h2>\r\n\r\n<nav class=\"navbar navbar-inverse\">\r\n    <div class=\"container-fluid\">\r\n        ");
            EndContext();
            BeginContext(221, 670, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6544e086b0244a7981b3592a40ef2197", async() => {
                BeginContext(273, 218, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <div class=\"form-group\">\r\n                    <label for=\"minDate\">Data Mínima</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"minDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 491, "", 518, 1);
#line 15 "C:\Users\anton\Repositorio\ProjetoCRUD\Views\RegistroVendas\BuscaSimples.cshtml"
WriteAttributeValue("", 498, ViewData["minDate"], 498, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(518, 207, true);
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"maxDate\">Data máxima</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"maxDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 725, "", 752, 1);
#line 19 "C:\Users\anton\Repositorio\ProjetoCRUD\Views\RegistroVendas\BuscaSimples.cshtml"
WriteAttributeValue("", 732, ViewData["maxDate"], 732, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(752, 132, true);
                WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-primary\">Filtro</button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(891, 146, true);
            WriteLiteral("\r\n    </div>\r\n</nav>\r\n<div class=\"panel panel-primary\">\r\n    <div class=\"panel-heading\">\r\n        <h3 class=\"panel-title\">Soma total das vendas = ");
            EndContext();
            BeginContext(1038, 42, false);
#line 28 "C:\Users\anton\Repositorio\ProjetoCRUD\Views\RegistroVendas\BuscaSimples.cshtml"
                                                   Write(Model.Sum(obj => obj.Valor).ToString("F2"));

#line default
#line hidden
            EndContext();
            BeginContext(1080, 215, true);
            WriteLiteral("</h3>\r\n    </div>\r\n    <div class=\"panel-body\">\r\n        <table class=\"table table-striped table-hover\">\r\n            <thead>\r\n                <tr class=\"success\">\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1296, 38, false);
#line 35 "C:\Users\anton\Repositorio\ProjetoCRUD\Views\RegistroVendas\BuscaSimples.cshtml"
                   Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1334, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1414, 40, false);
#line 38 "C:\Users\anton\Repositorio\ProjetoCRUD\Views\RegistroVendas\BuscaSimples.cshtml"
                   Write(Html.DisplayNameFor(model => model.Data));

#line default
#line hidden
            EndContext();
            BeginContext(1454, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1534, 44, false);
#line 41 "C:\Users\anton\Repositorio\ProjetoCRUD\Views\RegistroVendas\BuscaSimples.cshtml"
                   Write(Html.DisplayNameFor(model => model.Vendedor));

#line default
#line hidden
            EndContext();
            BeginContext(1578, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1658, 57, false);
#line 44 "C:\Users\anton\Repositorio\ProjetoCRUD\Views\RegistroVendas\BuscaSimples.cshtml"
                   Write(Html.DisplayNameFor(model => model.Vendedor.Departamento));

#line default
#line hidden
            EndContext();
            BeginContext(1715, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1795, 41, false);
#line 47 "C:\Users\anton\Repositorio\ProjetoCRUD\Views\RegistroVendas\BuscaSimples.cshtml"
                   Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(1836, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1916, 42, false);
#line 50 "C:\Users\anton\Repositorio\ProjetoCRUD\Views\RegistroVendas\BuscaSimples.cshtml"
                   Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1958, 95, true);
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 55 "C:\Users\anton\Repositorio\ProjetoCRUD\Views\RegistroVendas\BuscaSimples.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(2118, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2203, 37, false);
#line 59 "C:\Users\anton\Repositorio\ProjetoCRUD\Views\RegistroVendas\BuscaSimples.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2240, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2332, 39, false);
#line 62 "C:\Users\anton\Repositorio\ProjetoCRUD\Views\RegistroVendas\BuscaSimples.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Data));

#line default
#line hidden
            EndContext();
            BeginContext(2371, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2463, 48, false);
#line 65 "C:\Users\anton\Repositorio\ProjetoCRUD\Views\RegistroVendas\BuscaSimples.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Vendedor.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(2511, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2603, 61, false);
#line 68 "C:\Users\anton\Repositorio\ProjetoCRUD\Views\RegistroVendas\BuscaSimples.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Vendedor.Departamento.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(2664, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2756, 40, false);
#line 71 "C:\Users\anton\Repositorio\ProjetoCRUD\Views\RegistroVendas\BuscaSimples.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(2796, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2888, 41, false);
#line 74 "C:\Users\anton\Repositorio\ProjetoCRUD\Views\RegistroVendas\BuscaSimples.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2929, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 77 "C:\Users\anton\Repositorio\ProjetoCRUD\Views\RegistroVendas\BuscaSimples.cshtml"
                }

#line default
#line hidden
            BeginContext(3008, 58, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjetoVendas.Models.RegistroVendas>> Html { get; private set; }
    }
}
#pragma warning restore 1591
