#pragma checksum "C:\Users\Josip\Desktop\CrkvaProjekt\CrkvaProjekt\Views\Home\Vladicanski.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cce5ccaef58698b5c9445297efd6e6c65ddd3e88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Vladicanski), @"mvc.1.0.view", @"/Views/Home/Vladicanski.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cce5ccaef58698b5c9445297efd6e6c65ddd3e88", @"/Views/Home/Vladicanski.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1356b4eb60ecc96df2ba6a0dbfffaf563d42fcf9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Vladicanski : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Josip\Desktop\CrkvaProjekt\CrkvaProjekt\Views\Home\Vladicanski.cshtml"
  
    ViewData["Title"] = "Vladičanski dvor u Mostaru";
    Layout = "Basic";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cce5ccaef58698b5c9445297efd6e6c65ddd3e883294", async() => {
                WriteLiteral("\r\n    <style>\r\n        .neki {\r\n            padding: 10px;\r\n            background: #c2a073;\r\n        }\r\n            .neki p {\r\n                font-family: Arial, serif;\r\n            }\r\n    </style>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div class=""neki"">
    <p style=""text-align:justify;"">
        Vladičanski dvor u Mostaru sagrađen je 1910. godine u neobaroknom stilu, po projektu Karla Paržika, jednog od najznačajnijih arhitekata u Bosni i Hercegovini s kraja XIX i početka XX stoljeća. Na ovoj građevini posebno se ističu bogatstvo teksture i sofisticiranost dekoracije u enterijeru i na fasadama objekta. Do rata 1992. godine, kada je u velikoj mjeri stradao, Dvor je bio sjedište Episkopa i Eparhije zahumsko-hercegovačke, što je ponovo od 2011. godine. Obova proteklih godina načinila ga je ponovo biserom gradske arhitekture Mostara. Njegovu unutrašnjost, pored stilskog namještaja srpskog gradskog stanovništva i dragocjenih umjetničkih djela, krasi i eparhijska riznica, sa veoma značajnim ikonama, rukopisima i crkvenim predmetima, koji datiraju od XV do XX vijeka.
        </p>

</div>");
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
