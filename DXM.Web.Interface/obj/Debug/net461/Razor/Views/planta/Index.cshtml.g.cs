#pragma checksum "C:\DXM100 estudos\DXM.Web.Interface - zyess\DXM.Web.Interface\Views\planta\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53066bd9f2529d9a1fb6ff42d60bc62d2ed9e58a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_planta_Index), @"mvc.1.0.view", @"/Views/planta/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/planta/Index.cshtml", typeof(AspNetCore.Views_planta_Index))]
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
#line 1 "C:\DXM100 estudos\DXM.Web.Interface - zyess\DXM.Web.Interface\Views\_ViewImports.cshtml"
using DXM.Web.Interface;

#line default
#line hidden
#line 2 "C:\DXM100 estudos\DXM.Web.Interface - zyess\DXM.Web.Interface\Views\_ViewImports.cshtml"
using DXM.Web.Interface.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53066bd9f2529d9a1fb6ff42d60bc62d2ed9e58a", @"/Views/planta/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dbfc5f91b30706872d88ad7a7fe2ce93e5d6979", @"/Views/_ViewImports.cshtml")]
    public class Views_planta_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DXM.OEE.OEE>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\DXM100 estudos\DXM.Web.Interface - zyess\DXM.Web.Interface\Views\planta\Index.cshtml"
  
    ViewData["Title"] = "Planta Baixa";

#line default
#line hidden
            BeginContext(71, 1128, true);
            WriteLiteral(@"
<meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
<style>
    canvas {
        border: 1px solid #d3d3d3;
        background-color: #f1f1f1;
    }
</style>

<div class=""card-title mt-5 mb-5"">
    <div class=""row"">
        <div class=""col text-left"">
            <h2>Fábrica Planta Baixa</h2>
        </div>
    </div>
</div>



<hr>
<div class=""container-fluid row m-auto"">
    <canvas id=""view""></canvas>
</div>

<script type=""text/javascript"">
    var gameArea = {
        canvas: document.getElementById(""view""),
        ctx: document.getElementById(""view"").getContext(""2d""),
        width: 400,
        height: 400,
        Start: function () {
            this.canvas.width = 500;
            this.canvas.height = 500;
            this.context = this.ctx;
            this.ctx.drawImage(""~/images/fundo.jpg"",this.width,this.height)

        },
        clear: function () {
            this.ctx.clearRect(0,0,this.width,this.height)
        }
    }

    ");
            WriteLiteral("window.addEventListener(\"onload\", function () {\r\n        gameArea.Start();\r\n    }, false)\r\n\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DXM.OEE.OEE> Html { get; private set; }
    }
}
#pragma warning restore 1591
