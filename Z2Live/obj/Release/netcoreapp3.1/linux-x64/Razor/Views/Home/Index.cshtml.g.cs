#pragma checksum "E:\Dev\Z2Live\Z2Live\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a31fd14b050289a6a770eec0d05cb8351407efcf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "E:\Dev\Z2Live\Z2Live\Views\_ViewImports.cshtml"
using Z2Live;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Dev\Z2Live\Z2Live\Views\_ViewImports.cshtml"
using Z2Live.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a31fd14b050289a6a770eec0d05cb8351407efcf", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83c422f5bfa96fb873a9c4e2186cf99d906fb9e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Dev\Z2Live\Z2Live\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Zelda 2 Live - Random Zelda 2 Live Stream";
    Layout = "~/Views/Home/_HomeLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""text-center"" id=""streamSearchContent"">
        <h1 class=""display-4"">Zelda2.Live!</h1>
        <div id=""noResults"" style=""display:none;"">
            <h3>No Zelda 2 Live Streams found</h3>
            <button id=""searchAgain"" type=""button"" class=""btn btn-outline-warning"">Search again</button>
        </div>
        <div id=""searchContainer"" style=""display:none;"">
            <h3>Finding a random Zelda 2 Live Stream...</h3>
            <div id=""searchSpinner"" class=""spinner-border text-warning"" role=""status"">
                <span class=""sr-only"">Loading...</span>
            </div>
        </div>
    </div>
");
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
