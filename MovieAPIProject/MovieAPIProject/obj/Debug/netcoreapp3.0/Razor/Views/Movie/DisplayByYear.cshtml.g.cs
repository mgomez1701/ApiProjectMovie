#pragma checksum "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\API Project\MovieAPIProject\ApiProjectMovie\MovieAPIProject\MovieAPIProject\Views\Movie\DisplayByYear.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d8d4a2c4291195588cbb74e80d73617555f1c33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_DisplayByYear), @"mvc.1.0.view", @"/Views/Movie/DisplayByYear.cshtml")]
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
#line 1 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\API Project\MovieAPIProject\ApiProjectMovie\MovieAPIProject\MovieAPIProject\Views\_ViewImports.cshtml"
using MovieAPIProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\API Project\MovieAPIProject\ApiProjectMovie\MovieAPIProject\MovieAPIProject\Views\_ViewImports.cshtml"
using MovieAPIProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d8d4a2c4291195588cbb74e80d73617555f1c33", @"/Views/Movie/DisplayByYear.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eaee496547394b9b8f631bd66700521ecd4450d3", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_DisplayByYear : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<YearSearchRoot>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("../MovieAPIDb/AddFavorites"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("../Movie/DisplaySearch"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\API Project\MovieAPIProject\ApiProjectMovie\MovieAPIProject\MovieAPIProject\Views\Movie\DisplayByYear.cshtml"
  
    ViewData["Title"] = "DisplayByYear";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>DisplayByYear</h1>\r\n<table class=\"table align-items-xl-center\">\r\n    <tr>\r\n        <td>Title</td>\r\n        <td>Year</td>\r\n        <td>Rating</td>\r\n    </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 15 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\API Project\MovieAPIProject\ApiProjectMovie\MovieAPIProject\MovieAPIProject\Views\Movie\DisplayByYear.cshtml"
           Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 16 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\API Project\MovieAPIProject\ApiProjectMovie\MovieAPIProject\MovieAPIProject\Views\Movie\DisplayByYear.cshtml"
           Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 17 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\API Project\MovieAPIProject\ApiProjectMovie\MovieAPIProject\MovieAPIProject\Views\Movie\DisplayByYear.cshtml"
           Write(Model.Rated);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><img");
            BeginWriteAttribute("src", " src=", 376, "", 394, 1);
#nullable restore
#line 18 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\API Project\MovieAPIProject\ApiProjectMovie\MovieAPIProject\MovieAPIProject\Views\Movie\DisplayByYear.cshtml"
WriteAttributeValue("", 381, Model.Poster, 381, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></td>\r\n\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d8d4a2c4291195588cbb74e80d73617555f1c336474", async() => {
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"Title\"");
                BeginWriteAttribute("value", " value=\"", 549, "\"", 569, 1);
#nullable restore
#line 22 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\API Project\MovieAPIProject\ApiProjectMovie\MovieAPIProject\MovieAPIProject\Views\Movie\DisplayByYear.cshtml"
WriteAttributeValue("", 557, Model.Title, 557, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"hidden\" name=\"imdbID\"");
                BeginWriteAttribute("value", " value=\"", 629, "\"", 650, 1);
#nullable restore
#line 23 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\API Project\MovieAPIProject\ApiProjectMovie\MovieAPIProject\MovieAPIProject\Views\Movie\DisplayByYear.cshtml"
WriteAttributeValue("", 637, Model.imdbID, 637, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"hidden\" name=\"Year\"");
                BeginWriteAttribute("value", " value=\"", 708, "\"", 727, 1);
#nullable restore
#line 24 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\API Project\MovieAPIProject\ApiProjectMovie\MovieAPIProject\MovieAPIProject\Views\Movie\DisplayByYear.cshtml"
WriteAttributeValue("", 716, Model.Year, 716, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"hidden\" name=\"Type\"");
                BeginWriteAttribute("value", " value=\"", 785, "\"", 804, 1);
#nullable restore
#line 25 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\API Project\MovieAPIProject\ApiProjectMovie\MovieAPIProject\MovieAPIProject\Views\Movie\DisplayByYear.cshtml"
WriteAttributeValue("", 793, Model.Type, 793, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"hidden\" name=\"Poster\"");
                BeginWriteAttribute("value", " value=\"", 864, "\"", 885, 1);
#nullable restore
#line 26 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\API Project\MovieAPIProject\ApiProjectMovie\MovieAPIProject\MovieAPIProject\Views\Movie\DisplayByYear.cshtml"
WriteAttributeValue("", 872, Model.Poster, 872, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n                    <input type=\"submit\" value=\"Add To Favorites\" />\r\n\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n    \r\n</table>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d8d4a2c4291195588cbb74e80d73617555f1c3310709", async() => {
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<YearSearchRoot> Html { get; private set; }
    }
}
#pragma warning restore 1591
