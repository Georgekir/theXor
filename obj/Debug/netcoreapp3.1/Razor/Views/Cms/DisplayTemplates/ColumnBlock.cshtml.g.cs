#pragma checksum "C:\Users\gkiritsis\OneDrive\Personal Projects\theXOR\source.git\Views\Cms\DisplayTemplates\ColumnBlock.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "228dee3c94a9c4ec78ab6c44f54482d2d4dfa66f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cms_DisplayTemplates_ColumnBlock), @"mvc.1.0.view", @"/Views/Cms/DisplayTemplates/ColumnBlock.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"228dee3c94a9c4ec78ab6c44f54482d2d4dfa66f", @"/Views/Cms/DisplayTemplates/ColumnBlock.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca5b93007b6e082af5cc813bafde1a14cdc102f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Cms_DisplayTemplates_ColumnBlock : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Piranha.Extend.Blocks.ColumnBlock>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"row\">\n");
#line 4 "C:\Users\gkiritsis\OneDrive\Personal Projects\theXOR\source.git\Views\Cms\DisplayTemplates\ColumnBlock.cshtml"
     for (var n = 0; n < Model.Items.Count; n++)
    {

#line default
#line hidden
            WriteLiteral("        <div class=\"col-md\">\n            ");
#line 7 "C:\Users\gkiritsis\OneDrive\Personal Projects\theXOR\source.git\Views\Cms\DisplayTemplates\ColumnBlock.cshtml"
       Write(Html.DisplayFor(m => Model.Items[n], Model.Items[n].GetType().Name));

#line default
#line hidden
            WriteLiteral("\n        </div>\n");
#line 9 "C:\Users\gkiritsis\OneDrive\Personal Projects\theXOR\source.git\Views\Cms\DisplayTemplates\ColumnBlock.cshtml"
    }

#line default
#line hidden
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Piranha.Extend.Blocks.ColumnBlock> Html { get; private set; }
    }
}
#pragma warning restore 1591
