#pragma checksum "C:\Users\JerrodK\source\repos\MovieTheater\MovieTheater\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31be06c6b6b975817a08eaa60356649dd5d18d9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Privacy.cshtml", typeof(AspNetCore.Views_Home_Privacy))]
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
#line 1 "C:\Users\JerrodK\source\repos\MovieTheater\MovieTheater\Views\_ViewImports.cshtml"
using MovieTheater;

#line default
#line hidden
#line 2 "C:\Users\JerrodK\source\repos\MovieTheater\MovieTheater\Views\_ViewImports.cshtml"
using MovieTheater.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31be06c6b6b975817a08eaa60356649dd5d18d9c", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02af776d0317e24ceefdd367851f1a714110b937", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\JerrodK\source\repos\MovieTheater\MovieTheater\Views\Home\Privacy.cshtml"
  
    ViewData["Title"] = "Privacy Policy";

#line default
#line hidden
            BeginContext(50, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(55, 17, false);
#line 4 "C:\Users\JerrodK\source\repos\MovieTheater\MovieTheater\Views\Home\Privacy.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(72, 71, true);
            WriteLiteral("</h2>\r\n\r\n<p>Use this page to detail your site\'s privacy policy.</p>\r\n\r\n");
            EndContext();
#line 8 "C:\Users\JerrodK\source\repos\MovieTheater\MovieTheater\Views\Home\Privacy.cshtml"
 foreach (var v in Model)
{

#line default
#line hidden
            BeginContext(173, 10, true);
            WriteLiteral("    <div> ");
            EndContext();
            BeginContext(184, 11, false);
#line 10 "C:\Users\JerrodK\source\repos\MovieTheater\MovieTheater\Views\Home\Privacy.cshtml"
     Write(v.MovieName);

#line default
#line hidden
            EndContext();
            BeginContext(195, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 11 "C:\Users\JerrodK\source\repos\MovieTheater\MovieTheater\Views\Home\Privacy.cshtml"
}

#line default
#line hidden
            BeginContext(206, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591