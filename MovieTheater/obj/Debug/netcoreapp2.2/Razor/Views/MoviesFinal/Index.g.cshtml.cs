#pragma checksum "C:\Users\JerrodK\source\repos\MovieTheater\MovieTheater\Views\MoviesFinal\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74831abf57bf604bf9c22a21da1b610b240da537"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MoviesFinal_Index), @"mvc.1.0.view", @"/Views/MoviesFinal/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MoviesFinal/Index.cshtml", typeof(AspNetCore.Views_MoviesFinal_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74831abf57bf604bf9c22a21da1b610b240da537", @"/Views/MoviesFinal/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02af776d0317e24ceefdd367851f1a714110b937", @"/Views/_ViewImports.cshtml")]
    public class Views_MoviesFinal_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/MoviesFinal/Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:cadetblue"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\JerrodK\source\repos\MovieTheater\MovieTheater\Views\MoviesFinal\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(43, 16, true);
            WriteLiteral("<p>whatsup</p>\r\n");
            EndContext();
            BeginContext(59, 4596, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74831abf57bf604bf9c22a21da1b610b240da5374399", async() => {
                BeginContext(100, 282, true);
                WriteLiteral(@"
    <center>
        <img src="" https://pmcvariety.files.wordpress.com/2017/11/regal-cinemas-logo.jpg?w=1000&h=562&crop=1"" alt=""Regal"" width=""500"" height=""270"" />
    </center>
    <div class=""text-center"">

        <h1 class=""display-4""> Welcome To Regal </h1>
        <h1>");
                EndContext();
                BeginContext(382, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74831abf57bf604bf9c22a21da1b610b240da5375073", async() => {
                    BeginContext(411, 19, true);
                    WriteLiteral("Create a Movie Here");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(434, 3846, true);
                WriteLiteral(@" </h1>
    </div>


    <div id=""movies""></div>
    <center><input type=""button"" id=""thisButton"" value=""Get Movies"" onclick=""getMovies()"" /></center>
    <script>
        function getMovies() {
            $.ajax({
                url: 'https://movietheaterwebapp20190613024903.azurewebsites.net/api/movies/',
                type: 'GET',
                success: function (data, request) {
                    // this success function is a callback function
                    // data from Movies comes in arrays, so loop through the array
                    for (var i = 0; i < data.length; i++) {
                        //$('#movies').append('<div>' + data[i].movieName + `<input type=""button"" value = ""EXTERMINATE"" onclick = ""deleteMovies(\'${data[i].id}\')""></div>`);  //movies is an id from above
                        //$('#movies').append('<div style=""background-color: lightblue"">' + '<center>' + `<a href=""~/MoviesFinal/Edit/\'${data[i].id}\'"">` + data[i].movieName + `</a>` + "" "" + "" "" + `<in");
                WriteLiteral(@"put type=""button"" value = ""EXTERMINATE"" onclick = ""deleteMovies(\'${data[i].id}\')""> </center> </div>`);
                        
                        $('#movies').append('<br>' + '<div style=""background-color: lightblue"">' + '<center>' + `<a href=""MoviesFinal/Edit/${data[i].id}"">` + data[i].movieName +"" (Click to Edit)""+ `</a>` + "" "" + "" "" + `<input type=""button"" value = ""Delete"" onclick = ""deleteMovies(\'${data[i].id}\')""> </center> </div>`);
                        $('#movies').append('<center>' + `<input type=""button"" id = iAmButton${i} value=""Get Info: ${data[i].movieName}"" onclick=""getInfo(${data[i].id}, ${i})""></center> </div >`);
                        $('#movies').append(`<div id=""thisLine${i}""></div>`);
                        //if you look at the data that comes from api ont the web, it says movieName instead of MovieName
                        //$('#movies').append('<center>' + ""12:00"" + "" 15:00 "" + "" 18:00 "" + '</center>');

                    }
                },
                ");
                WriteLiteral(@"error: function (request) {
                    // handle error
                }
            })
            $('#thisButton').hide();
        }

        function deleteMovies(id) {
            $.ajax({
                url: 'https://movietheaterwebapp20190613024903.azurewebsites.net/api/movies/' + id,
                type: 'DELETE',
                success: function () {
                    //alert(""movie deleted!"");
                    $('#movies').html("""");
                    getMovies();
                    //$ means you are using jquery library
                },
                error: function (request) {
                    // handle error
                }
            })

        }


        function getInfo(id, k) {
            $.ajax({
                url: 'https://movietheaterwebapp20190613024903.azurewebsites.net/api/movies/' + id,
                type: 'GET',
                success: function (data) {
                    for (var i = 0; i < data.length; i++) {
      ");
                WriteLiteral(@"                  $(`#iAmButton${k}`).hide();
                        $(`#thisLine${k}`).append('<center>' + '<stan style=""background-color: yellow"">' + `${data[i].movieName}` + '<br>' + ""Director(s) = "" + `${data[i].directorName}` + '<br>' + ""Running Time = "" + `${data[i].runTime}` + "" minutes"" + '</stan>' +'</center>');
                        $(`#thisLine${k}`).append('<center>' + '<a href = ""https://www.showtimes.com/movie-theaters/edwards-marketplace-stadium-10-5787/"" target=""_blank"">' + `<input type=""button"" value = ""View Timeslots"">` + '</a>' + '</center>');
                        //alert(""hi"");
                    }
                }
            })
        }
    </script>




    <!--
    <p>You can edit the items below. Click on them!</p>
");
                EndContext();
#line 85 "C:\Users\JerrodK\source\repos\MovieTheater\MovieTheater\Views\MoviesFinal\Index.cshtml"
     foreach (var v in Model)
    {

#line default
#line hidden
                BeginContext(4318, 53, true);
                WriteLiteral("        <div>\r\n            <ul>\r\n                <li>");
                EndContext();
                BeginContext(4371, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74831abf57bf604bf9c22a21da1b610b240da53710835", async() => {
                    BeginContext(4407, 11, false);
#line 89 "C:\Users\JerrodK\source\repos\MovieTheater\MovieTheater\Views\MoviesFinal\Index.cshtml"
                                                  Write(v.MovieName);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4380, "~/MoviesFinal/Edit/", 4380, 19, true);
#line 89 "C:\Users\JerrodK\source\repos\MovieTheater\MovieTheater\Views\MoviesFinal\Index.cshtml"
AddHtmlAttributeValue("", 4399, v.Id, 4399, 5, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4422, 42, true);
                WriteLiteral("</li>\r\n            </ul>\r\n        </div>\r\n");
                EndContext();
#line 92 "C:\Users\JerrodK\source\repos\MovieTheater\MovieTheater\Views\MoviesFinal\Index.cshtml"
        //Convention of naming an edit button is -> ControllerName, ActionName, Id
        //See that the button just simply redirects to an edit page
    }

#line default
#line hidden
                BeginContext(4624, 24, true);
                WriteLiteral("\r\n    <!-- -->\r\n    \r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4655, 4, true);
            WriteLiteral("\r\n\r\n");
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
