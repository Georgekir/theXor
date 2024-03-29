#pragma checksum "C:\Users\gkiritsis\OneDrive\Personal Projects\theXOR\source.git\Views\Cms\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91023fd30e8be7d6c3923c7af2eb40481671a91a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cms_Post), @"mvc.1.0.view", @"/Views/Cms/Post.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91023fd30e8be7d6c3923c7af2eb40481671a91a", @"/Views/Cms/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca5b93007b6e082af5cc813bafde1a14cdc102f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Cms_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TheXor.Models.BlogPost>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\gkiritsis\OneDrive\Personal Projects\theXOR\source.git\Views\Cms\Post.cshtml"
  
    ViewBag.Title = Model.Title;

#line default
#line hidden
            WriteLiteral("\r\n<div class=\"container\">\r\n    <article>\r\n        <header>\r\n");
#line 10 "C:\Users\gkiritsis\OneDrive\Personal Projects\theXOR\source.git\Views\Cms\Post.cshtml"
             if (Model.Hero.PrimaryImage.HasValue)
            {

#line default
#line hidden
            WriteLiteral("                <img");
            BeginWriteAttribute("src", " src=\"", 245, "\"", 310, 1);
#line 12 "C:\Users\gkiritsis\OneDrive\Personal Projects\theXOR\source.git\Views\Cms\Post.cshtml"
WriteAttributeValue("", 251, Url.Content(Model.Hero.PrimaryImage.Resize(Api, 930, 360)), 251, 59, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#line 13 "C:\Users\gkiritsis\OneDrive\Personal Projects\theXOR\source.git\Views\Cms\Post.cshtml"
            }

#line default
#line hidden
            WriteLiteral("            <h1>");
#line 14 "C:\Users\gkiritsis\OneDrive\Personal Projects\theXOR\source.git\Views\Cms\Post.cshtml"
           Write(Model.Title);

#line default
#line hidden
            WriteLiteral("</h1>\r\n            <p class=\"post-meta\">\r\n                <strong>In</strong> <a");
            BeginWriteAttribute("href", " href=\"", 437, "\"", 474, 2);
            WriteAttributeValue("", 444, "/category/", 444, 10, true);
#line 16 "C:\Users\gkiritsis\OneDrive\Personal Projects\theXOR\source.git\Views\Cms\Post.cshtml"
WriteAttributeValue("", 454, Model.Category.Slug, 454, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">");
#line 16 "C:\Users\gkiritsis\OneDrive\Personal Projects\theXOR\source.git\Views\Cms\Post.cshtml"
                                                                        Write(Model.Category.Title);

#line default
#line hidden
            WriteLiteral("</a>\r\n                <span class=\"sep\">&#9670;</span>\r\n                <strong>Tags</strong>\r\n");
#line 19 "C:\Users\gkiritsis\OneDrive\Personal Projects\theXOR\source.git\Views\Cms\Post.cshtml"
                 foreach (var tag in Model.Tags)
                {

#line default
#line hidden
            WriteLiteral("                    <span class=\"tag\"><a");
            BeginWriteAttribute("href", " href=\"", 701, "\"", 722, 2);
            WriteAttributeValue("", 708, "/tag/", 708, 5, true);
#line 21 "C:\Users\gkiritsis\OneDrive\Personal Projects\theXOR\source.git\Views\Cms\Post.cshtml"
WriteAttributeValue("", 713, tag.Slug, 713, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">#");
#line 21 "C:\Users\gkiritsis\OneDrive\Personal Projects\theXOR\source.git\Views\Cms\Post.cshtml"
                                                           Write(tag.Title);

#line default
#line hidden
            WriteLiteral("</a></span>\r\n");
#line 22 "C:\Users\gkiritsis\OneDrive\Personal Projects\theXOR\source.git\Views\Cms\Post.cshtml"
                }

#line default
#line hidden
            WriteLiteral("                <span class=\"sep\">&#9670;</span>\r\n                <strong>Published</strong>\r\n                ");
#line 25 "C:\Users\gkiritsis\OneDrive\Personal Projects\theXOR\source.git\Views\Cms\Post.cshtml"
           Write(Model.Published.Value.ToString("yyyy-MM-dd"));

#line default
#line hidden
            WriteLiteral("\r\n            </p>\r\n        </header>\r\n        ");
#line 28 "C:\Users\gkiritsis\OneDrive\Personal Projects\theXOR\source.git\Views\Cms\Post.cshtml"
   Write(Html.DisplayFor(m => m.Blocks));

#line default
#line hidden
            WriteLiteral("\r\n    </article>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Piranha.IApi Api { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Piranha.AspNetCore.Services.IApplicationService WebApp { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TheXor.Models.BlogPost> Html { get; private set; }
    }
}
#pragma warning restore 1591
