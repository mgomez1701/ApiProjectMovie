#pragma checksum "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\API Project\MovieAPIProject\MovieAPIProject\Views\Movie\DisplaySearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c739364cc0e0da545a94ab8d3580935ec061752"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_DisplaySearch), @"mvc.1.0.view", @"/Views/Movie/DisplaySearch.cshtml")]
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
#line 1 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\API Project\MovieAPIProject\MovieAPIProject\Views\_ViewImports.cshtml"
using MovieAPIProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\API Project\MovieAPIProject\MovieAPIProject\Views\_ViewImports.cshtml"
using MovieAPIProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c739364cc0e0da545a94ab8d3580935ec061752", @"/Views/Movie/DisplaySearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eaee496547394b9b8f631bd66700521ecd4450d3", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_DisplaySearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SearchRoot>
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
#line 2 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\API Project\MovieAPIProject\MovieAPIProject\Views\Movie\DisplaySearch.cshtml"
  
    ViewData["Title"] = "DisplaySearch";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Search Movies</h1>\r\n<table class=\"table align-items-xl-center\">\r\n    <tr>\r\n        <td>Title</td>\r\n        <td>iMDb iD</td>\r\n        <td>Year</td>\r\n    </tr>\r\n");
#nullable restore
#line 14 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\API Project\MovieAPIProject\MovieAPIProject\Views\Movie\DisplaySearch.cshtml"
     foreach (Search searchMovie in Model.Search)
    {



#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 19 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\API Project\MovieAPIProject\MovieAPIProject\Views\Movie\DisplaySearch.cshtml"
   Write(searchMovie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 20 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\API Project\MovieAPIProject\MovieAPIProject\Views\Movie\DisplaySearch.cshtml"
   Write(searchMovie.imdbID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 21 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\API Project\MovieAPIProject\MovieAPIProject\Views\Movie\DisplaySearch.cshtml"
   Write(searchMovie.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c739364cc0e0da545a94ab8d3580935ec0617526020", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"Title\"");
                BeginWriteAttribute("value", " value=\"", 507, "\"", 533, 1);
#nullable restore
#line 24 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\API Project\MovieAPIProject\MovieAPIProject\Views\Movie\DisplaySearch.cshtml"
WriteAttributeValue("", 515, searchMovie.Title, 515, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"imdbID\"");
                BeginWriteAttribute("value", " value=\"", 577, "\"", 604, 1);
#nullable restore
#line 25 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\API Project\MovieAPIProject\MovieAPIProject\Views\Movie\DisplaySearch.cshtml"
WriteAttributeValue("", 585, searchMovie.imdbID, 585, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"Year\"");
                BeginWriteAttribute("value", " value=\"", 646, "\"", 671, 1);
#nullable restore
#line 26 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\API Project\MovieAPIProject\MovieAPIProject\Views\Movie\DisplaySearch.cshtml"
WriteAttributeValue("", 654, searchMovie.Year, 654, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"Type\"");
                BeginWriteAttribute("value", " value=\"", 713, "\"", 738, 1);
#nullable restore
#line 27 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\API Project\MovieAPIProject\MovieAPIProject\Views\Movie\DisplaySearch.cshtml"
WriteAttributeValue("", 721, searchMovie.Type, 721, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"Poster\"");
                BeginWriteAttribute("value", " value=\"", 782, "\"", 809, 1);
#nullable restore
#line 28 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\API Project\MovieAPIProject\MovieAPIProject\Views\Movie\DisplaySearch.cshtml"
WriteAttributeValue("", 790, searchMovie.Poster, 790, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n    <input type=\"submit\" value=\"Add To Favorites\" />\r\n\r\n");
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
            WriteLiteral("</td>\r\n\r\n</tr>\r\n");
#nullable restore
#line 35 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\API Project\MovieAPIProject\MovieAPIProject\Views\Movie\DisplaySearch.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c739364cc0e0da545a94ab8d3580935ec06175210222", async() => {
                WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SearchRoot> Html { get; private set; }
    }
}
#pragma warning restore 1591
