#pragma checksum "C:\Users\Josip\Desktop\CrkvaProjekt\CrkvaProjekt\Views\Shared\memberNovosti.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fc3bf5e3d143cd18a333bb26ed85a3a5824eea2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_memberNovosti), @"mvc.1.0.view", @"/Views/Shared/memberNovosti.cshtml")]
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
#line 1 "C:\Users\Josip\Desktop\CrkvaProjekt\CrkvaProjekt\Views\_ViewImports.cshtml"
using CrkvaProjekt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Josip\Desktop\CrkvaProjekt\CrkvaProjekt\Views\_ViewImports.cshtml"
using CrkvaProjekt.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fc3bf5e3d143cd18a333bb26ed85a3a5824eea2", @"/Views/Shared/memberNovosti.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1356b4eb60ecc96df2ba6a0dbfffaf563d42fcf9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_memberNovosti : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CrkvaProjekt.ViewModels.PaginatedList<CrkvaProjekt.Models.Novosti>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/startbootstrap-blog-home-gh-pages/vendor/bootstrap/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/startbootstrap-blog-home-gh-pages/css/blog-home.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("profile", new global::Microsoft.AspNetCore.Html.HtmlString("http://gmpg.org/xfn/11"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IndexNovosti", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/startbootstrap-blog-home-gh-pages/vendor/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/startbootstrap-blog-home-gh-pages/vendor/bootstrap/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fc3bf5e3d143cd18a333bb26ed85a3a5824eea26915", async() => {
                WriteLiteral("\n\n    <meta charset=\"utf-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 295, "\"", 305, 0);
                EndWriteAttribute();
                WriteLiteral(">\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 331, "\"", 341, 0);
                EndWriteAttribute();
                WriteLiteral(">\n\n    <title>Saborna Crkva Mostar</title>\n\n    <!-- Bootstrap core CSS -->\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2fc3bf5e3d143cd18a333bb26ed85a3a5824eea27754", async() => {
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
                WriteLiteral("\n    <!-- Custom styles for this template -->\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2fc3bf5e3d143cd18a333bb26ed85a3a5824eea28977", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <style type=""text/css"">

    body { background-image: url(""https://cdn.hipwallpaper.com/i/21/64/hF6GSH.jpg""); background-repeat: no-repeat; background-attachment: fixed; background-size: cover; }

        .mb-4 {
            border-bottom: thick double #000000;
        }

        .card-body {
            background: #8597aa;
        }

        .moj-img {
            padding: 0px;
            margin-bottom: 7px;
            margin-right: 7px;
            border: solid 1px #000000;
            text-align: center;
            width: 200px;
            height: 200px;
            float: left;
            vertical-align: top;
            object-fit: cover;
        }

        .text-new {
            background: #6c7d8f;
            color: #212529;
        }
        .card-header {
            background-color: #00738b;
        }
        .lista {
            list-style-type: none;
            margin: 0px;
            padding: 0px;
        }
        #headerslika {
            position: relative;
 ");
                WriteLiteral(@"           top: 25px;
            padding-right: 15px;
            padding-left: 15px;
            padding-bottom: 20px;
            text-align: center;
            color: white;
        }
        #container1 {
            background: #adb5bd;
        }
        .centered {
            position: absolute;
            left: 35%;
            top: 8px;
            font-family: Georgia,sans-serif;
            font-weight: bold;
            font-size: 200%;
        }

        ");
                WriteLiteral(@"@media(max-width:415px) {
            #headerslika {
                padding-top: 45px;
            }
        }

            .lista li a {
                text-align: center;
                display: inline;
                color: #000;
                font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
                font-size: 18px;
                letter-spacing: 0px;
            }

                .lista li a:visited {
                    text-decoration: none;
                    border: 0px;
                }
         .col-md-4{
             padding-top:75px;
         }
        ");
                WriteLiteral("@media (max-width:405px) {\r\n            .moj-img {\r\n                float: none;\r\n            }\r\n        }\n    </style>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fc3bf5e3d143cd18a333bb26ed85a3a5824eea213327", async() => {
                WriteLiteral(@"

    <!-- Navigation -->
    <nav class=""navbar navbar-expand-lg navbar-dark bg-dark fixed-top"">
        <div class=""container"">
            <a class=""navbar-brand"" href=""/Home/Index"" style=""font-size:200%;"">Saborna Crkva Mostar</a>
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarResponsive"" aria-controls=""navbarResponsive"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbarResponsive"">
                <ul class=""navbar-nav ml-auto"">
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Home/Index"">
                            Home                      
                        </a>
                    </li>
                    <li class=""nav-item active"">
                        <a class=""nav-link"" href=""/Home/IndexNovosti"">Novosti
                            <span class=""sr-onl");
                WriteLiteral(@"y"">(current)</span>
                        </a>

                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#"">Mobilna aplikacija</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Home/Kontakti"">Kontakti</a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>

    <!-- Page Content -->
    <div id=""container1"" class=""container"">
        <div id=""headerslika"">
            <a href=""/Home/Index"">
                <img style=""object-fit:cover; width:100%; height:100px;"" src=""https://www.frontal.ba/img/s/750x400/upload/images/DEJAN/hrammostar.jpg"" />
            </a>
            <div class=""centered"">Saborna Crkva Mostar</div>
        </div>
        <div class=""row"">

            <!-- Blog Entries Column -->
            <div class=""col-md-8"">

                <h1 class=""my-4"">
                    Novosti
                </h1>

                <");
                WriteLiteral("!-- Blog Post -->\n");
#nullable restore
#line 158 "C:\Users\Josip\Desktop\CrkvaProjekt\CrkvaProjekt\Views\Shared\memberNovosti.cshtml"
                 foreach (var novosti in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("    <div class=\"card mb-4\">\n\n        <div class=\"card-body\">\n");
#nullable restore
#line 163 "C:\Users\Josip\Desktop\CrkvaProjekt\CrkvaProjekt\Views\Shared\memberNovosti.cshtml"
             if (novosti.Slika != null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("    <img class=\"moj-img\"");
                BeginWriteAttribute("src", " src=\"", 5273, "\"", 5342, 2);
                WriteAttributeValue("", 5279, "data:image;base64,", 5279, 18, true);
#nullable restore
#line 165 "C:\Users\Josip\Desktop\CrkvaProjekt\CrkvaProjekt\Views\Shared\memberNovosti.cshtml"
WriteAttributeValue("", 5297, System.Convert.ToBase64String(novosti.Slika), 5297, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Card image cap\"> ");
#nullable restore
#line 165 "C:\Users\Josip\Desktop\CrkvaProjekt\CrkvaProjekt\Views\Shared\memberNovosti.cshtml"
                                                                                                                     }
else
{

#line default
#line hidden
#nullable disable
                WriteLiteral("    <img class=\"moj-img\" src=\"https://upload.wikimedia.org/wikipedia/commons/thumb/6/6c/No_image_3x4.svg/1200px-No_image_3x4.svg.png\" alt=\"Card image cap\" />");
#nullable restore
#line 168 "C:\Users\Josip\Desktop\CrkvaProjekt\CrkvaProjekt\Views\Shared\memberNovosti.cshtml"
                                                                                                                                                             }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <h2 class=\"card-title\">");
#nullable restore
#line 169 "C:\Users\Josip\Desktop\CrkvaProjekt\CrkvaProjekt\Views\Shared\memberNovosti.cshtml"
                              Write(novosti.Naslov);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\n");
#nullable restore
#line 170 "C:\Users\Josip\Desktop\CrkvaProjekt\CrkvaProjekt\Views\Shared\memberNovosti.cshtml"
             if (novosti.Text.Length > 200)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("    <p class=\"card-text\">");
#nullable restore
#line 172 "C:\Users\Josip\Desktop\CrkvaProjekt\CrkvaProjekt\Views\Shared\memberNovosti.cshtml"
                    Write(novosti.Text.Substring(0, 200));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ...</p> ");
#nullable restore
#line 172 "C:\Users\Josip\Desktop\CrkvaProjekt\CrkvaProjekt\Views\Shared\memberNovosti.cshtml"
                                                                 }
else
{

#line default
#line hidden
#nullable disable
                WriteLiteral("    <p class=\"card-text\">");
#nullable restore
#line 175 "C:\Users\Josip\Desktop\CrkvaProjekt\CrkvaProjekt\Views\Shared\memberNovosti.cshtml"
                    Write(novosti.Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>");
#nullable restore
#line 175 "C:\Users\Josip\Desktop\CrkvaProjekt\CrkvaProjekt\Views\Shared\memberNovosti.cshtml"
                                          }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <a");
                BeginWriteAttribute("href", " href=\"", 5780, "\"", 5844, 2);
                WriteAttributeValue("", 5787, "/ProcitajVise/PrikaziNovosti?NovostiID=", 5787, 39, true);
#nullable restore
#line 176 "C:\Users\Josip\Desktop\CrkvaProjekt\CrkvaProjekt\Views\Shared\memberNovosti.cshtml"
WriteAttributeValue("", 5826, novosti.NovostiID, 5826, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-primary\">Pročitaj više &rarr;</a>\n        </div>\n        <div class=\"card-footer text-new\">\n            Objavljeno: ");
#nullable restore
#line 179 "C:\Users\Josip\Desktop\CrkvaProjekt\CrkvaProjekt\Views\Shared\memberNovosti.cshtml"
                   Write(novosti.DatumObjavljivanja.ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n        </div>\n    </div>");
#nullable restore
#line 182 "C:\Users\Josip\Desktop\CrkvaProjekt\CrkvaProjekt\Views\Shared\memberNovosti.cshtml"
          }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                <!-- Blog Post -->
                <!--<div class=""card mb-4"">
                <img class=""card-img-top"" src=""http://placehold.it/750x300"" alt=""Card image cap"">
                <div class=""card-body"">
                    <h2 class=""card-title"">Post Title</h2>
                    <p class=""card-text"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Reiciendis aliquid atque, nulla? Quos cum ex quis soluta, a laboriosam. Dicta expedita corporis animi vero voluptate voluptatibus possimus, veniam magni quis!</p>
                    <a href=""#"" class=""btn btn-primary"">Read More &rarr;</a>
                </div>
                <div class=""card-footer text-muted"">
                    Posted on January 1, 2020 by
                    <a href=""#"">Start Bootstrap</a>
                </div>
            </div>-->
                <!-- Pagination -->
");
#nullable restore
#line 197 "C:\Users\Josip\Desktop\CrkvaProjekt\CrkvaProjekt\Views\Shared\memberNovosti.cshtml"
                   var prevDisabled = !Model.HasPreviousPage ? "disabled" : "";
                    var nextDisabled = !Model.HasNextPage ? "disabled" : ""; 

#line default
#line hidden
#nullable disable
                WriteLiteral("                <ul class=\"pagination justify-content-center mb-4\">\n                    <li class=\"page-item\">\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fc3bf5e3d143cd18a333bb26ed85a3a5824eea221983", async() => {
                    WriteLiteral("&larr; Novije");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 201 "C:\Users\Josip\Desktop\CrkvaProjekt\CrkvaProjekt\Views\Shared\memberNovosti.cshtml"
                                                                WriteLiteral(Model.PageIndex -1);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 7301, "btn", 7301, 3, true);
                AddHtmlAttributeValue(" ", 7304, "btn-default", 7305, 12, true);
#nullable restore
#line 201 "C:\Users\Josip\Desktop\CrkvaProjekt\CrkvaProjekt\Views\Shared\memberNovosti.cshtml"
AddHtmlAttributeValue(" ", 7316, prevDisabled, 7317, 13, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    </li>\n                    <li class=\"page-item disabled\">\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fc3bf5e3d143cd18a333bb26ed85a3a5824eea225041", async() => {
                    WriteLiteral("Starije &rarr;");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 205 "C:\Users\Josip\Desktop\CrkvaProjekt\CrkvaProjekt\Views\Shared\memberNovosti.cshtml"
                                      WriteLiteral(Model.PageIndex + 1);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 7588, "btn", 7588, 3, true);
                AddHtmlAttributeValue(" ", 7591, "btn-default", 7592, 12, true);
#nullable restore
#line 206 "C:\Users\Josip\Desktop\CrkvaProjekt\CrkvaProjekt\Views\Shared\memberNovosti.cshtml"
AddHtmlAttributeValue(" ", 7603, nextDisabled, 7604, 13, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </li>
                </ul>

            </div>


            <!-- Sidebar Widgets Column -->
            <div class=""col-md-4"">

                <div class=""card my-4"">
                    <h5 class=""card-header"">Promijeni jezik</h5>
                    <div class=""card-body"">
                        <button class=""btn btn-secondary""");
                BeginWriteAttribute("onclick", " onclick=\"", 7994, "\"", 8058, 3);
                WriteAttributeValue("", 8004, "location.href=\'", 8004, 15, true);
#nullable restore
#line 219 "C:\Users\Josip\Desktop\CrkvaProjekt\CrkvaProjekt\Views\Shared\memberNovosti.cshtml"
WriteAttributeValue("", 8019, Url.Action("IndexNovostiCir", "Home"), 8019, 38, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 8057, "\'", 8057, 1, true);
                EndWriteAttribute();
                WriteLiteral(@">Ćirilica</button>
                    </div>
                </div>

                <!-- Search Widget -->
                <div class=""card my-4"">
                    <h5 class=""card-header"">Pretraži novosti</h5>
                    <div class=""card-body"">
                        <div class=""input-group"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fc3bf5e3d143cd18a333bb26ed85a3a5824eea229245", async() => {
                    WriteLiteral(@"
                                <input style=""float:right;"" type=""submit"" class=""btn btn-secondary"" value=""Go!"" />
                                <div style=""overflow:hidden; padding-right:.5em;"">
                                    <input type=""text"" name=""searchString"" class=""form-control"" placeholder=""Pretraži..."">
                                </div>

                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </div>
                    </div>
                </div>

                <!-- Categories Widget -->
                <div class=""card my-4"">
                    <h5 class=""card-header"">Informacije</h5>
                    <div class=""card-body"">
                        <div class=""row"">
                            <div class=""col-lg-6"">
                                <ul class=""lista"">
                                    <li>
                                        <a href=""/Home/Istorija"">Istorija</a>
                                    </li>
                                    <li>
                                        <a href=""/Home/Parohije"">Parohije</a>
                                    </li>
                                    <li>
                                        <a href=""/Home/Zdanja"">Zdanja</a>
                                    </li>
                                </ul>
                            </div>
                            <div class=""col-lg-6"">
      ");
                WriteLiteral(@"                          <ul class=""lista"">
                                    <li>
                                        <a href=""/Home/Riznica"">Riznica</a>
                                    </li>
                                    <li>
                                        <a href=""/Home/Biblioteka"">Biblioteka</a>
                                    </li>
                                    <li>
                                        <a href=""/Home/Linkovi"">Korisni linkovi</a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>

                <!-- Side Widget -->
                <div class=""card my-4"">
                    <h5 class=""card-header"">Društvene mreže</h5>
                    <div class=""card-body"">
                        <div class=""row"">
                            <div class=""col-lg-6"">
                                <ul class=""lista"">
   ");
                WriteLiteral(@"                                 <li>
                                        <table style="" width: 147px; text-align: center; "">
                                            <tbody>
                                                <tr>
                                                    <td>
                                                        <a href=""https://twitter.com/SabornaCrkvaMos"" target=""_blank"">
                                                            <img src=""http://saborna-crkva-mostar.com/novav/wp-content/uploads/2013/04/twitter.png"" />

                                                        </a>
                                                    </td>
                                                    <td>
                                                        <a href=""https://www.facebook.com/%D0%A1%D0%90%D0%91%D0%9E%D0%A0%D0%9D%D0%90-%D0%A6%D0%A0%D0%9A%D0%92%D0%90-%D0%A1%D0%92%D0%95%D0%A2%D0%95-%D0%A2%D0%A0%D0%9E%D0%88%D0%98%D0%A6%D0%95-%D0%A1%D0%9F%D0%A6%D0%9E-%D0%9C%D0%BE%D1%81%D1%");
                WriteLiteral(@"82%D0%B0%D1%80-572045772819163"" target=""_blank"">
                                                            <img src=""http://saborna-crkva-mostar.com/novav/wp-content/uploads/2013/04/facebook.png"" />
                                                        </a>
                                                    </td>
                                                    <td>
                                                        <a href=""https://www.youtube.com/channel/UCTuaQax2uM4IoNxoiGmUCwg"" target=""_blank"">
                                                            <img src=""http://saborna-crkva-mostar.com/novav/wp-content/uploads/2013/04/youtube.png"" />
                                                        </a>
                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                </ul>
                            </div>
        ");
                WriteLiteral(@"                </div>

                    </div>
                </div>

            </div>

        </div>
        <!-- /.row -->

    </div>
    <!-- /.container -->
    <!-- Footer -->
    <footer class=""py-5 bg-dark"">
        <div class=""container"">
            <p class=""m-0 text-center text-white"">Copyright &copy; Fakultet informacijskih tehnologija 2020</p>
        </div>
        <!-- /.container -->
    </footer>

    <!-- Bootstrap core JavaScript -->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fc3bf5e3d143cd18a333bb26ed85a3a5824eea236139", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fc3bf5e3d143cd18a333bb26ed85a3a5824eea237237", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    <div>\n        ");
#nullable restore
#line 330 "C:\Users\Josip\Desktop\CrkvaProjekt\CrkvaProjekt\Views\Shared\memberNovosti.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    </div>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CrkvaProjekt.ViewModels.PaginatedList<CrkvaProjekt.Models.Novosti>> Html { get; private set; }
    }
}
#pragma warning restore 1591
