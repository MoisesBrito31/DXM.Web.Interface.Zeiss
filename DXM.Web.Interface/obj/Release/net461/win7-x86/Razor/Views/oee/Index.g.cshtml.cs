#pragma checksum "C:\Users\automacao\Desktop\DXM100 estudos\DXM.Web.Interface\DXM.Web.Interface\Views\oee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23089d266f1ef7bddc42db07cd6014cce060401e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_oee_Index), @"mvc.1.0.view", @"/Views/oee/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/oee/Index.cshtml", typeof(AspNetCore.Views_oee_Index))]
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
#line 1 "C:\Users\automacao\Desktop\DXM100 estudos\DXM.Web.Interface\DXM.Web.Interface\Views\_ViewImports.cshtml"
using DXM.Web.Interface;

#line default
#line hidden
#line 2 "C:\Users\automacao\Desktop\DXM100 estudos\DXM.Web.Interface\DXM.Web.Interface\Views\_ViewImports.cshtml"
using DXM.Web.Interface.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23089d266f1ef7bddc42db07cd6014cce060401e", @"/Views/oee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dbfc5f91b30706872d88ad7a7fe2ce93e5d6979", @"/Views/_ViewImports.cshtml")]
    public class Views_oee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DXM.OEE.OEE>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\automacao\Desktop\DXM100 estudos\DXM.Web.Interface\DXM.Web.Interface\Views\oee\Index.cshtml"
  
    ViewData["Title"] = "OEE";

#line default
#line hidden
            BeginContext(62, 355, true);
            WriteLiteral(@"
<div class=""card-title mt-5 mb-5"">
<div class=""row"">
    <div class=""col text-left""> 
        <h2>Fábrica Visão Geral</h2>
    </div>
    <div class=""m-auto custom-control-inline"">
        
        <label class=""col-form-label mr-3 "" for=""linhas"">linhas:</label> 
        <input type=""number"" class=""form-control mr-3 "" name=""linhas"" id=""linhas""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 417, "\"", 442, 1);
#line 15 "C:\Users\automacao\Desktop\DXM100 estudos\DXM.Web.Interface\DXM.Web.Interface\Views\oee\Index.cshtml"
WriteAttributeValue("", 425, Model.quantidade, 425, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(443, 179, true);
            WriteLiteral(" style=\"max-width:100px\" />\r\n        <button class=\"btn btn-primary \" onclick=\"linhaAltera()\" type=\"button\">Alterar</button>\r\n    </div>\r\n    <div class=\"col text-right\">     \r\n\r\n");
            EndContext();
#line 20 "C:\Users\automacao\Desktop\DXM100 estudos\DXM.Web.Interface\DXM.Web.Interface\Views\oee\Index.cshtml"
         if (Model.emulador == 0)
        {

#line default
#line hidden
            BeginContext(668, 43, true);
            WriteLiteral("            <button class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 711, "\"", 743, 3);
            WriteAttributeValue("", 721, "emula(", 721, 6, true);
#line 22 "C:\Users\automacao\Desktop\DXM100 estudos\DXM.Web.Interface\DXM.Web.Interface\Views\oee\Index.cshtml"
WriteAttributeValue("", 727, Model.emulador, 727, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 742, ")", 742, 1, true);
            EndWriteAttribute();
            BeginContext(744, 48, true);
            WriteLiteral(" type=\"button\">\r\n                <span id=\"emul\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 792, "\"", 824, 3);
            WriteAttributeValue("", 802, "emula(", 802, 6, true);
#line 23 "C:\Users\automacao\Desktop\DXM100 estudos\DXM.Web.Interface\DXM.Web.Interface\Views\oee\Index.cshtml"
WriteAttributeValue("", 808, Model.emulador, 808, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 823, ")", 823, 1, true);
            EndWriteAttribute();
            BeginContext(825, 49, true);
            WriteLiteral(">Iniciar emulador</span>\r\n            </button>\r\n");
            EndContext();
#line 25 "C:\Users\automacao\Desktop\DXM100 estudos\DXM.Web.Interface\DXM.Web.Interface\Views\oee\Index.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(910, 42, true);
            WriteLiteral("            <button class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 952, "\"", 984, 3);
            WriteAttributeValue("", 962, "emula(", 962, 6, true);
#line 28 "C:\Users\automacao\Desktop\DXM100 estudos\DXM.Web.Interface\DXM.Web.Interface\Views\oee\Index.cshtml"
WriteAttributeValue("", 968, Model.emulador, 968, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 983, ")", 983, 1, true);
            EndWriteAttribute();
            BeginContext(985, 48, true);
            WriteLiteral(" type=\"button\">\r\n                <span id=\"emul\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1033, "\"", 1065, 3);
            WriteAttributeValue("", 1043, "emula(", 1043, 6, true);
#line 29 "C:\Users\automacao\Desktop\DXM100 estudos\DXM.Web.Interface\DXM.Web.Interface\Views\oee\Index.cshtml"
WriteAttributeValue("", 1049, Model.emulador, 1049, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 1064, ")", 1064, 1, true);
            EndWriteAttribute();
            BeginContext(1066, 47, true);
            WriteLiteral(">Parar emulador</span>\r\n            </button>\r\n");
            EndContext();
#line 31 "C:\Users\automacao\Desktop\DXM100 estudos\DXM.Web.Interface\DXM.Web.Interface\Views\oee\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1124, 84, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n</div>\r\n\r\n\r\n\r\n<hr>\r\n<div class=\"container-fluid row m-auto\">\r\n");
            EndContext();
#line 41 "C:\Users\automacao\Desktop\DXM100 estudos\DXM.Web.Interface\DXM.Web.Interface\Views\oee\Index.cshtml"
     for (int x = 0; x < Model.Linhas.Count; x++)
    {

#line default
#line hidden
            BeginContext(1266, 135, true);
            WriteLiteral("        <div class=\"col \">\r\n            <div class=\"bg-light text-center border rounded mb-5\" style=\"min-width:250px; max-width:300px;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1401, "\"", 1449, 3);
            WriteAttributeValue("", 1411, "document.location.href=\'/oee/linha/", 1411, 35, true);
#line 44 "C:\Users\automacao\Desktop\DXM100 estudos\DXM.Web.Interface\DXM.Web.Interface\Views\oee\Index.cshtml"
WriteAttributeValue("", 1446, x, 1446, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 1448, "\'", 1448, 1, true);
            EndWriteAttribute();
            BeginContext(1450, 22, true);
            WriteLiteral(">\r\n                <h3");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1472, "\"", 1481, 2);
            WriteAttributeValue("", 1477, "l", 1477, 1, true);
#line 45 "C:\Users\automacao\Desktop\DXM100 estudos\DXM.Web.Interface\DXM.Web.Interface\Views\oee\Index.cshtml"
WriteAttributeValue(" ", 1478, x, 1479, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1482, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1484, 20, false);
#line 45 "C:\Users\automacao\Desktop\DXM100 estudos\DXM.Web.Interface\DXM.Web.Interface\Views\oee\Index.cshtml"
                         Write(Model.Linhas[x].nome);

#line default
#line hidden
            EndContext();
            BeginContext(1504, 27, true);
            WriteLiteral("</h3>\r\n                <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1531, "\"", 1538, 1);
#line 46 "C:\Users\automacao\Desktop\DXM100 estudos\DXM.Web.Interface\DXM.Web.Interface\Views\oee\Index.cshtml"
WriteAttributeValue("", 1536, x, 1536, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1539, 27, true);
            WriteLiteral("></div>\r\n                <p");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1566, "\"", 1575, 2);
            WriteAttributeValue("", 1571, "p", 1571, 1, true);
#line 47 "C:\Users\automacao\Desktop\DXM100 estudos\DXM.Web.Interface\DXM.Web.Interface\Views\oee\Index.cshtml"
WriteAttributeValue(" ", 1572, x, 1573, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1576, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1578, 22, false);
#line 47 "C:\Users\automacao\Desktop\DXM100 estudos\DXM.Web.Interface\DXM.Web.Interface\Views\oee\Index.cshtml"
                        Write(Model.Linhas[x].Estado);

#line default
#line hidden
            EndContext();
            BeginContext(1600, 42, true);
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 50 "C:\Users\automacao\Desktop\DXM100 estudos\DXM.Web.Interface\DXM.Web.Interface\Views\oee\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1649, 1432, true);
            WriteLiteral(@"



</div>



<script>
    var data;
    var gage = []

    function linhaAltera() {
        var valor = document.getElementById(""linhas"").value
        var xhp = new XMLHttpRequest()
        
        xhp.onreadystatechange = function () {
            if (this.readyState === 4 && this.status === 200) {
                var re = this.responseText
                document.location.reload()
            }
        }
        xhp.open(""Get"", ""/oee/setLinhas?valor="" + valor);
        xhp.send();
    }

    function emula(valor) {
        
        if (valor == 0) {
            valor=1
        }
        else {
            valor=0
        }       

        var xhp = new XMLHttpRequest()
        xhp.onreadystatechange = function () {
            if (this.readyState === 4 && this.status === 200) {
                var re = this.responseText
               document.location.reload()
            }
        }
        xhp.open(""Get"", ""/oee/emula?valor=""+valor);
        xhp.send();
    ");
            WriteLiteral(@"}



    var sectors = [{
        color: ""#c00002"",
        lo: 0,
        hi: 20,
    }, {
        color: ""#febf00"",
        lo: 21,
        hi: 40,
    }, {
        color: ""#fdf500"",
        lo: 41,
        hi: 60,
    }, {
        color: ""#92d14f"",
        lo: 61,
        hi: 80,
    }, {
        color: ""#00af50"",
        lo: 81,
        hi: 100,
        }];

    var linhas = ");
            EndContext();
            BeginContext(3082, 16, false);
#line 121 "C:\Users\automacao\Desktop\DXM100 estudos\DXM.Web.Interface\DXM.Web.Interface\Views\oee\Index.cshtml"
            Write(Model.quantidade);

#line default
#line hidden
            EndContext();
            BeginContext(3098, 1328, true);
            WriteLiteral(@"



    for(var x = 0; x < linhas; x++) {
        var a = new JustGage({
            id: (x).toString(),
            value: 0,
            min: 0,
            max: 100,
            title: ""OEE"",
            symbol: '%',
            pointer: true,
            customSectors: sectors,
            relativeGaugeSize: true
        })
        gage.push(a)

    }





    setInterval(function () {
        getlinhas();
    }, 1000)

    function getlinhas() {
        var xhp = new XMLHttpRequest()
        xhp.onreadystatechange = function () {
            if (this.readyState === 4 && this.status === 200) {
                var re = this.responseText
                data = JSON.parse(re);
                if (data[0].estado == ""DXM OffLine"") {
                    document.location.href = ""/oee/offline"";
                }
                else {
                    for (x = 0; x < data.length; x++) {
                        document.getElementById(`l ${x}`).innerHTML = data[x].nome
 ");
            WriteLiteral(@"                       document.getElementById(`p ${x}`).innerHTML = data[x].estado
                        gage[x].refresh(data[x].oee)
                    }
                }

            }
        }
        xhp.open(""Get"", ""/oee/conjunto_linhas"");
        xhp.send();
    }

</script>


");
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
