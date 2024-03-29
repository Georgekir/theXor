#pragma checksum "C:\Users\gkiritsis\OneDrive\Personal Projects\theXOR\source.git\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb308d45c6e141e0aa06271af7ebf97f850e5351"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cms_DisplayTemplates_ImageGalleryBlock), @"mvc.1.0.view", @"/Views/Cms/DisplayTemplates/ImageGalleryBlock.cshtml")]
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
#line 2 "C:\Users\gkiritsis\OneDrive\Personal Projects\theXOR\source.git\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml"
using Piranha.Extend.Blocks;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb308d45c6e141e0aa06271af7ebf97f850e5351", @"/Views/Cms/DisplayTemplates/ImageGalleryBlock.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca5b93007b6e082af5cc813bafde1a14cdc102f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Cms_DisplayTemplates_ImageGalleryBlock : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Piranha.Extend.Blocks.ImageGalleryBlock>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\gkiritsis\OneDrive\Personal Projects\theXOR\source.git\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml"
  
    var unique = "gallery-" + Guid.NewGuid().ToString();

#line default
#line hidden
            WriteLiteral("\n<div");
            BeginWriteAttribute("id", " id=\"", 143, "\"", 155, 1);
#line 7 "C:\Users\gkiritsis\OneDrive\Personal Projects\theXOR\source.git\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml"
WriteAttributeValue("", 148, unique, 148, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" class=\"carousel slide gallery-block\" data-ride=\"carousel\">\n    <ol class=\"carousel-indicators\">\n");
#line 9 "C:\Users\gkiritsis\OneDrive\Personal Projects\theXOR\source.git\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml"
         for (var n = 0; n < Model.Items.Count; n++)
        {

#line default
#line hidden
            WriteLiteral("            <li data-target=\"#");
#line 11 "C:\Users\gkiritsis\OneDrive\Personal Projects\theXOR\source.git\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml"
                         Write(unique);

#line default
#line hidden
            WriteLiteral("\" data-slide-to=\"");
#line 11 "C:\Users\gkiritsis\OneDrive\Personal Projects\theXOR\source.git\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml"
                                                 Write(n);

#line default
#line hidden
            WriteLiteral("\"");
            BeginWriteAttribute("class", " class=\"", 373, "\"", 406, 1);
#line 11 "C:\Users\gkiritsis\OneDrive\Personal Projects\theXOR\source.git\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml"
WriteAttributeValue("", 381, n == 0 ? "active" : "", 381, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral("></li>\n");
#line 12 "C:\Users\gkiritsis\OneDrive\Personal Projects\theXOR\source.git\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml"
        }

#line default
#line hidden
            WriteLiteral("    </ol>\n    <div class=\"carousel-inner\">\n");
#line 15 "C:\Users\gkiritsis\OneDrive\Personal Projects\theXOR\source.git\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml"
         foreach (var item in Model.Items)
        {

#line default
#line hidden
            WriteLiteral("            <div");
            BeginWriteAttribute("class", " class=\"", 536, "\"", 604, 2);
            WriteAttributeValue("", 544, "carousel-item", 544, 13, true);
#line 17 "C:\Users\gkiritsis\OneDrive\Personal Projects\theXOR\source.git\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml"
WriteAttributeValue(" ", 557, item == Model.Items.First() ? "active" : "", 558, 46, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">\n                <img");
            BeginWriteAttribute("src", " src=\"", 627, "\"", 712, 1);
#line 18 "C:\Users\gkiritsis\OneDrive\Personal Projects\theXOR\source.git\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml"
WriteAttributeValue("", 633, Url.Content(WebApp.Media.ResizeImage(((ImageBlock)item).Body.Media, 890, 482)), 633, 79, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block w-100\">\n            </div>\n");
#line 20 "C:\Users\gkiritsis\OneDrive\Personal Projects\theXOR\source.git\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml"
        }

#line default
#line hidden
            WriteLiteral("    </div>\n    <a class=\"carousel-control-prev\"");
            BeginWriteAttribute("href", " href=\"", 813, "\"", 828, 2);
            WriteAttributeValue("", 820, "#", 820, 1, true);
#line 22 "C:\Users\gkiritsis\OneDrive\Personal Projects\theXOR\source.git\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml"
WriteAttributeValue("", 821, unique, 821, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" data-slide=\"prev\">\n        <span class=\"carousel-control-prev-icon\" aria-hidden=\"true\"></span>\n        <span class=\"sr-only\">Previous</span>\n    </a>\n    <a class=\"carousel-control-next\"");
            BeginWriteAttribute("href", " href=\"", 1030, "\"", 1045, 2);
            WriteAttributeValue("", 1037, "#", 1037, 1, true);
#line 26 "C:\Users\gkiritsis\OneDrive\Personal Projects\theXOR\source.git\Views\Cms\DisplayTemplates\ImageGalleryBlock.cshtml"
WriteAttributeValue("", 1038, unique, 1038, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" data-slide=\"next\">\n        <span class=\"carousel-control-next-icon\" aria-hidden=\"true\"></span>\n        <span class=\"sr-only\">Next</span>\n    </a>\n</div>\n");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Piranha.Extend.Blocks.ImageGalleryBlock> Html { get; private set; }
    }
}
#pragma warning restore 1591
