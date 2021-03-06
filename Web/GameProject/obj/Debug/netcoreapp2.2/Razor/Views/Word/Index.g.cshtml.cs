#pragma checksum "D:\Projects\Gameroject\Web\GameProject\Views\Word\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e911ff217e19a3e0358105d1a260dcff997d69e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Word_Index), @"mvc.1.0.view", @"/Views/Word/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Word/Index.cshtml", typeof(AspNetCore.Views_Word_Index))]
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
#line 1 "D:\Projects\Gameroject\Web\GameProject\Views\_ViewImports.cshtml"
using GameProject;

#line default
#line hidden
#line 2 "D:\Projects\Gameroject\Web\GameProject\Views\_ViewImports.cshtml"
using GameProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e911ff217e19a3e0358105d1a260dcff997d69e", @"/Views/Word/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a5f903eed222c93f8d279f59e370b380f87db2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Word_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GameProject.Service.Common.WordService.Models.WordModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(77, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Projects\Gameroject\Web\GameProject\Views\Word\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(120, 35, true);
            WriteLiteral("\r\n<h1>Список слов</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(155, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e911ff217e19a3e0358105d1a260dcff997d69e3772", async() => {
                BeginContext(178, 20, true);
                WriteLiteral("Добавить новое слово");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(202, 44, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <tbody>\r\n");
            EndContext();
#line 14 "D:\Projects\Gameroject\Web\GameProject\Views\Word\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(287, 103, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                <span style=\"color: blueviolet;\">\r\n                    ");
            EndContext();
            BeginContext(391, 45, false);
#line 19 "D:\Projects\Gameroject\Web\GameProject\Views\Word\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.SecretWord));

#line default
#line hidden
            EndContext();
            BeginContext(436, 118, true);
            WriteLiteral("\r\n                </span>\r\n                \r\n                <br/>\r\n                <span style=\"font-size: xx-small\">");
            EndContext();
            BeginContext(555, 13, false);
#line 23 "D:\Projects\Gameroject\Web\GameProject\Views\Word\Index.cshtml"
                                             Write(item.Question);

#line default
#line hidden
            EndContext();
            BeginContext(568, 78, true);
            WriteLiteral("</span>\r\n            </td>\r\n              \r\n            <td>\r\n                ");
            EndContext();
            BeginContext(647, 68, false);
#line 27 "D:\Projects\Gameroject\Web\GameProject\Views\Word\Index.cshtml"
           Write(Html.ActionLink("Редактировать", "Create", new { wordId = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(715, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(736, 58, false);
#line 28 "D:\Projects\Gameroject\Web\GameProject\Views\Word\Index.cshtml"
           Write(Html.ActionLink("Удалить", "Remove", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(794, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 31 "D:\Projects\Gameroject\Web\GameProject\Views\Word\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(837, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GameProject.Service.Common.WordService.Models.WordModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
