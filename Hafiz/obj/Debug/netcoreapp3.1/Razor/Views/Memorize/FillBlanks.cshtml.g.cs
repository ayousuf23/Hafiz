#pragma checksum "C:\Users\Abdullah Yousuf\Documents\Hafiz\Hafiz\Views\Memorize\FillBlanks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b5b3a3b2d018a76aacf9b4d05fd3b07d93068b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Memorize_FillBlanks), @"mvc.1.0.view", @"/Views/Memorize/FillBlanks.cshtml")]
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
#line 1 "C:\Users\Abdullah Yousuf\Documents\Hafiz\Hafiz\Views\_ViewImports.cshtml"
using Hafiz;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abdullah Yousuf\Documents\Hafiz\Hafiz\Views\_ViewImports.cshtml"
using Hafiz.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b5b3a3b2d018a76aacf9b4d05fd3b07d93068b1", @"/Views/Memorize/FillBlanks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c84f639b3dad500e35e127073d5615c51b73cf3", @"/Views/_ViewImports.cshtml")]
    public class Views_Memorize_FillBlanks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Fonts/stylesheet.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        function checkAnswers() {
            var correct = 0;


            

            $('input[type=""text""]').each(function () {

                $(this).attr(""readOnly"", true);

                console.log($(this).prop('value'));
                console.log($(this).data('answer'));

                if ($(this).prop('value') == $(this).data('answer')) {
                    $(this).parent().parent().addClass(""bg-success"");
                    correct++;
                } else {
                    $(this).parent().parent().addClass(""bg-danger"");
                }
            });

            $('p').each(function () {
                $(this).css('display', 'inline');
            });


            $('#score').text(correct);
            $('#score').parent().show();
        }

        function reload() {
            location.reload();
        }
    </script>
");
            }
            );
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9b5b3a3b2d018a76aacf9b4d05fd3b07d93068b14826", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<h2>Fill in the blanks</h2>\r\n<h2>Surah ");
#nullable restore
#line 41 "C:\Users\Abdullah Yousuf\Documents\Hafiz\Hafiz\Views\Memorize\FillBlanks.cshtml"
     Write(Model.EN_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<div class=\"mt-5\"></div>\r\n<h2 style=\"display: none;\">Score: <b id=\"score\"></b><b>/");
#nullable restore
#line 43 "C:\Users\Abdullah Yousuf\Documents\Hafiz\Hafiz\Views\Memorize\FillBlanks.cshtml"
                                                   Write(Model.Questions.Length);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h2>\r\n");
#nullable restore
#line 44 "C:\Users\Abdullah Yousuf\Documents\Hafiz\Hafiz\Views\Memorize\FillBlanks.cshtml"
 for (int i = 0; i < Model.Questions.Length; i++)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row mt-3\">\r\n        <div class=\"col\">\r\n            <h4>Ayat ");
#nullable restore
#line 48 "C:\Users\Abdullah Yousuf\Documents\Hafiz\Hafiz\Views\Memorize\FillBlanks.cshtml"
                Write(Model.Questions[i].TextAyat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            <h3 class=\"quran\">");
#nullable restore
#line 49 "C:\Users\Abdullah Yousuf\Documents\Hafiz\Hafiz\Views\Memorize\FillBlanks.cshtml"
                         Write(Model.Questions[i].Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <ul class=\"list-group\">\r\n                <li class=\"list-group-item\">\r\n                    <div class=\"form-check-inline\">\r\n                        <label");
            BeginWriteAttribute("for", " for=\"", 1573, "\"", 1581, 1);
#nullable restore
#line 53 "C:\Users\Abdullah Yousuf\Documents\Hafiz\Hafiz\Views\Memorize\FillBlanks.cshtml"
WriteAttributeValue("", 1579, i, 1579, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Type the word here:</label>\r\n                        <input type=\"text\"");
            BeginWriteAttribute("id", " id=\"", 1654, "\"", 1661, 1);
#nullable restore
#line 54 "C:\Users\Abdullah Yousuf\Documents\Hafiz\Hafiz\Views\Memorize\FillBlanks.cshtml"
WriteAttributeValue("", 1659, i, 1659, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control quran\" data-answer=\"");
#nullable restore
#line 54 "C:\Users\Abdullah Yousuf\Documents\Hafiz\Hafiz\Views\Memorize\FillBlanks.cshtml"
                                                                                      Write(Model.Questions[i].Choices[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" />\r\n                    </div>\r\n                </li>\r\n");
#nullable restore
#line 57 "C:\Users\Abdullah Yousuf\Documents\Hafiz\Hafiz\Views\Memorize\FillBlanks.cshtml"
                  string id = "answer" + i;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </ul>\r\n            <p");
            BeginWriteAttribute("id", " id=\"", 1871, "\"", 1879, 1);
#nullable restore
#line 60 "C:\Users\Abdullah Yousuf\Documents\Hafiz\Hafiz\Views\Memorize\FillBlanks.cshtml"
WriteAttributeValue("", 1876, id, 1876, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display: none;\">Correct Answer: <b>");
#nullable restore
#line 60 "C:\Users\Abdullah Yousuf\Documents\Hafiz\Hafiz\Views\Memorize\FillBlanks.cshtml"
                                                             Write(Model.Questions[i].Choices[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 63 "C:\Users\Abdullah Yousuf\Documents\Hafiz\Hafiz\Views\Memorize\FillBlanks.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row mt-3"">
    <div class=""col text-center"">
        <button class=""btn btn-primary"" onclick=""checkAnswers()"">Submit</button>
    </div>
    <div class=""col text-center"">
        <button class=""btn btn-primary"" onclick=""reload()"">Try Again</button>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
