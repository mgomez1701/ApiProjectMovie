#pragma checksum "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\API Project\MovieAPIProject\ApiProjectMovie\MovieAPIProject\MovieAPIProject\Views\MovieAPIDb\FavoriteList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22a7b7c3dfdab847358616fd95c1a047e7c7cd00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MovieAPIDb_FavoriteList), @"mvc.1.0.view", @"/Views/MovieAPIDb/FavoriteList.cshtml")]
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
#nullable restore
#line 5 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\API Project\MovieAPIProject\ApiProjectMovie\MovieAPIProject\MovieAPIProject\Views\MovieAPIDb\FavoriteList.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22a7b7c3dfdab847358616fd95c1a047e7c7cd00", @"/Views/MovieAPIDb/FavoriteList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eaee496547394b9b8f631bd66700521ecd4450d3", @"/Views/_ViewImports.cshtml")]
    public class Views_MovieAPIDb_FavoriteList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Favorites>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("../MovieAPIDb/RemoveFavorite"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\API Project\MovieAPIProject\ApiProjectMovie\MovieAPIProject\MovieAPIProject\Views\MovieAPIDb\FavoriteList.cshtml"
  
    ViewData["Title"] = "FavoriteList";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"FavoriteList\">Favorite List</h1>\r\n<table class=\"table\">\r\n    <tr>\r\n        <td>Title</td>\r\n        <td>iMDb iD</td>\r\n        <td>Year</td>\r\n    </tr>\r\n");
#nullable restore
#line 15 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\API Project\MovieAPIProject\ApiProjectMovie\MovieAPIProject\MovieAPIProject\Views\MovieAPIDb\FavoriteList.cshtml"
     foreach (Favorites favMovie in Model)
    {

        if (User.FindFirst(ClaimTypes.NameIdentifier).Value == favMovie.UserId)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\API Project\MovieAPIProject\ApiProjectMovie\MovieAPIProject\MovieAPIProject\Views\MovieAPIDb\FavoriteList.cshtml"
           Write(favMovie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\API Project\MovieAPIProject\ApiProjectMovie\MovieAPIProject\MovieAPIProject\Views\MovieAPIDb\FavoriteList.cshtml"
           Write(favMovie.Imdbid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\API Project\MovieAPIProject\ApiProjectMovie\MovieAPIProject\MovieAPIProject\Views\MovieAPIDb\FavoriteList.cshtml"
           Write(favMovie.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22a7b7c3dfdab847358616fd95c1a047e7c7cd006386", async() => {
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 688, "\"", 716, 1);
#nullable restore
#line 27 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\API Project\MovieAPIProject\ApiProjectMovie\MovieAPIProject\MovieAPIProject\Views\MovieAPIDb\FavoriteList.cshtml"
WriteAttributeValue("", 696, favMovie.FavoriteId, 696, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"submit\" value=\"Remove From Favorites\" />\r\n\r\n                ");
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
            WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 34 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\API Project\MovieAPIProject\ApiProjectMovie\MovieAPIProject\MovieAPIProject\Views\MovieAPIDb\FavoriteList.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Favorites>> Html { get; private set; }
    }
}
#pragma warning restore 1591
