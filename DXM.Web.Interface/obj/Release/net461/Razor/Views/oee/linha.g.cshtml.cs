#pragma checksum "C:\DXM100 estudos\DXM.Web.Interface - zyess\DXM.Web.Interface\Views\oee\linha.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a51629c4ecc27c0ef4359ad602f0c186ab89ae55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_oee_linha), @"mvc.1.0.view", @"/Views/oee/linha.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/oee/linha.cshtml", typeof(AspNetCore.Views_oee_linha))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a51629c4ecc27c0ef4359ad602f0c186ab89ae55", @"/Views/oee/linha.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dbfc5f91b30706872d88ad7a7fe2ce93e5d6979", @"/Views/_ViewImports.cshtml")]
    public class Views_oee_linha : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DXM.OEE.Linha>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\DXM100 estudos\DXM.Web.Interface - zyess\DXM.Web.Interface\Views\oee\linha.cshtml"
  
    ViewData["Title"] = "linha";

#line default
#line hidden
            BeginContext(66, 100, true);
            WriteLiteral("\r\n<div class=\"card-title mt-5 mb-5\">\r\n    <div class=\"row\">\r\n        <div class=\"col text-left\"><h2>");
            EndContext();
            BeginContext(167, 10, false);
#line 9 "C:\DXM100 estudos\DXM.Web.Interface - zyess\DXM.Web.Interface\Views\oee\linha.cshtml"
                                  Write(Model.nome);

#line default
#line hidden
            EndContext();
            BeginContext(177, 366, true);
            WriteLiteral(@"</h2></div>    
        <div class=""col text-right"">
            <div class=""btn-group"">
                <button type=""button"" class=""btn btn-primary"" onclick=""window.location.href='/oee/index'"">Fábrica</button>
                <button type=""button"" class=""btn btn-primary disabled"">ao vivo</button>
                <button type=""button"" class=""btn btn-primary""");
            EndContext();
            BeginWriteAttribute("onclick", "  onclick=\"", 543, "\"", 601, 3);
            WriteAttributeValue("", 554, "window.location.href=\'/oee/historico/", 554, 37, true);
#line 14 "C:\DXM100 estudos\DXM.Web.Interface - zyess\DXM.Web.Interface\Views\oee\linha.cshtml"
WriteAttributeValue("", 591, Model.id, 591, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 600, "\'", 600, 1, true);
            EndWriteAttribute();
            BeginContext(602, 507, true);
            WriteLiteral(@">Histórico</button>
                <!--<button type=""button"" class=""btn btn-danger"">Zerar</button>-->
            </div>
        </div>
    </div>
    
</div>
<hr>
<div class=""container-fluid m-auto"">
    <div class=""row"">
        <div class=""col "">
            <div class=""gauge m-auto"" id=""GOEE""><!--oee gauge aqui--></div>
            <div class=""form-group "">
                <label>Status:</label>
                <h2 class=""p-2 rounded border border-dark text-center""><span id=""estado"">");
            EndContext();
            BeginContext(1110, 12, false);
#line 28 "C:\DXM100 estudos\DXM.Web.Interface - zyess\DXM.Web.Interface\Views\oee\linha.cshtml"
                                                                                    Write(Model.Estado);

#line default
#line hidden
            EndContext();
            BeginContext(1122, 304, true);
            WriteLiteral(@"</span></h2>
            </div>
        </div>
        <div class=""col "">
            <div class=""gauge m-auto"" id=""Gdis""></div>
            <div class=""form-group "">
                <label>Operando:</label>
                <input id=""operando"" class=""form-control text-center"" readonly=""readonly""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1426, "\"", 1447, 1);
#line 35 "C:\DXM100 estudos\DXM.Web.Interface - zyess\DXM.Web.Interface\Views\oee\linha.cshtml"
WriteAttributeValue("", 1434, Model.t_prod, 1434, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1448, 191, true);
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"form-group \">\r\n                <label>Parado:</label>\r\n                <input id=\"parado\" class=\"form-control text-center\" readonly=\"readonly\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1639, "\"", 1659, 1);
#line 39 "C:\DXM100 estudos\DXM.Web.Interface - zyess\DXM.Web.Interface\Views\oee\linha.cshtml"
WriteAttributeValue("", 1647, Model.t_par, 1647, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1660, 1051, true);
            WriteLiteral(@" />
            </div>
            <div class=""form-group "">
                <label>Agendado:</label>
                <input id=""agendado"" class=""form-control text-center"" value="""" onclick=""t_p_progBtnF()"" onkeyup=""agendadoChange()""/>
                <div class=""row mt-2"">
                    <div class=""col"">
                        <button class=""btn btn-block btn-primary invisible"" type=""button"" id=""t_p_progBtn"" onclick=""salvaT_p_prog(true)"">Salvar</button>
                    </div>
                    <div class=""col"">
                        <button class=""btn btn-block btn-danger invisible"" type=""button"" id=""t_p_progCls"" onclick=""salvaT_p_prog(false)"">Cancelar</button>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col "">
            <div class=""gauge m-auto"" id=""Gq""></div>
            <div class=""form-group "">
                <label>Produzido:</label>
                <input id=""produzindo"" type=""text"" readonly=""readonly"" class");
            WriteLiteral("=\"form-control text-center\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2711, "\"", 2733, 1);
#line 58 "C:\DXM100 estudos\DXM.Web.Interface - zyess\DXM.Web.Interface\Views\oee\linha.cshtml"
WriteAttributeValue("", 2719, Model.cont_in, 2719, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2734, 25, true);
            WriteLiteral(" />\r\n            </div>\r\n");
            EndContext();
#line 60 "C:\DXM100 estudos\DXM.Web.Interface - zyess\DXM.Web.Interface\Views\oee\linha.cshtml"
             if (Model.forma == 0)
            {

#line default
#line hidden
            BeginContext(2810, 196, true);
            WriteLiteral("                <div class=\"form-group \">\r\n                    <label>Reprovados:</label>\r\n                    <input id=\"aprovado\" type=\"text\" readonly=\"readonly\" class=\"form-control text-center\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3006, "\"", 3029, 1);
#line 64 "C:\DXM100 estudos\DXM.Web.Interface - zyess\DXM.Web.Interface\Views\oee\linha.cshtml"
WriteAttributeValue("", 3014, Model.cont_out, 3014, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3030, 237, true);
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"form-group \">\r\n                    <label>Forma de Contagem:</label>\r\n                    <select class=\"form-control\" id=\"forma\" onchange=\"formaAsinc()\">\r\n                        ");
            EndContext();
            BeginContext(3267, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "717e45f9672d47c1861cb712d82ffdc4", async() => {
                BeginContext(3305, 22, true);
                WriteLiteral("Contador de rejeitados");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3336, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(3362, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67fc4906963043419bb8e0f5341a2e98", async() => {
                BeginContext(3380, 21, true);
                WriteLiteral("Contador de Aprovados");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3410, 57, true);
            WriteLiteral("\r\n                    </select>\r\n                </div>\r\n");
            EndContext();
#line 73 "C:\DXM100 estudos\DXM.Web.Interface - zyess\DXM.Web.Interface\Views\oee\linha.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(3515, 195, true);
            WriteLiteral("                <div class=\"form-group \">\r\n                    <label>Aprovados:</label>\r\n                    <input id=\"aprovado\" type=\"text\" readonly=\"readonly\" class=\"form-control text-center\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3710, "\"", 3733, 1);
#line 78 "C:\DXM100 estudos\DXM.Web.Interface - zyess\DXM.Web.Interface\Views\oee\linha.cshtml"
WriteAttributeValue("", 3718, Model.cont_out, 3718, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3734, 238, true);
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"form-group \">\r\n                    <label>Forma de Contagem:</label>\r\n                    <select class=\"form-control\" id=\"forma\" onchange=\"formaAsinc()\"> \r\n                        ");
            EndContext();
            BeginContext(3972, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ede402d67b5448b4b8260fa24c9be291", async() => {
                BeginContext(3991, 22, true);
                WriteLiteral("Contador de rejeitados");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4022, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(4048, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75c52da06a35409c9e07c0d9ac2e2ddd", async() => {
                BeginContext(4086, 21, true);
                WriteLiteral("Contador de Aprovados");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4116, 57, true);
            WriteLiteral("\r\n                    </select>\r\n                </div>\r\n");
            EndContext();
#line 87 "C:\DXM100 estudos\DXM.Web.Interface - zyess\DXM.Web.Interface\Views\oee\linha.cshtml"
            }

#line default
#line hidden
            BeginContext(4188, 298, true);
            WriteLiteral(@"


        </div>
        <div class=""col "">
            <div class=""gauge m-auto"" id=""Gper""></div>
            <div class=""form-group "">
                <label>Velocidade Atual:</label>
                <input id=""velocidade"" type=""text"" readonly=""readonly"" class=""form-control text-center""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4486, "\"", 4512, 2);
#line 96 "C:\DXM100 estudos\DXM.Web.Interface - zyess\DXM.Web.Interface\Views\oee\linha.cshtml"
WriteAttributeValue("", 4494, Model.vel_atu, 4494, 14, false);

#line default
#line hidden
            WriteAttributeValue(" ", 4508, "p/m", 4509, 4, true);
            EndWriteAttribute();
            BeginContext(4513, 187, true);
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"form-group \">\r\n                <label>Esperada:</label>\r\n                <input id=\"velo_esp\" type=\"text\" class=\"form-control text-center\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4700, "\"", 4726, 2);
#line 100 "C:\DXM100 estudos\DXM.Web.Interface - zyess\DXM.Web.Interface\Views\oee\linha.cshtml"
WriteAttributeValue("", 4708, Model.vel_esp, 4708, 14, false);

#line default
#line hidden
            WriteAttributeValue(" ", 4722, "p/m", 4723, 4, true);
            EndWriteAttribute();
            BeginContext(4727, 1825, true);
            WriteLiteral(@" onclick=""vel_espBtn()"" />
                <div class=""row mt-2"">
                    <div class=""col"">
                        <button class=""btn btn-block btn-primary invisible"" type=""button"" id=""vel_espBtn"" onclick=""salvaVel_esp(true)"">Salvar</button>
                    </div>
                    <div class=""col"">
                        <button class=""btn btn-block btn-danger invisible"" type=""button"" id=""vel_espCls"" onclick=""salvaVel_esp(false)"">Cancelar</button>
                    </div>
                    
                   
                </div>
            </div>
        </div>

    </div>

</div>

<script>

    var ediVel_esp = false
    var input_h_p_pro =0

    function vel_espBtn() {
        ediVel_esp = true;
        document.getElementById(""vel_espBtn"").setAttribute(""class"", ""btn btn-block btn-primary visible"")
        document.getElementById(""vel_espCls"").setAttribute(""class"", ""btn btn-block btn-danger visible"")
        document.getElementById(""velo_esp"").value=""");
            WriteLiteral(@"""        
    }

    function salvaVel_esp(acao) {        
        document.getElementById(""vel_espBtn"").setAttribute(""class"", ""btn btn-block btn-primary invisible"")
        document.getElementById(""vel_espCls"").setAttribute(""class"", ""btn btn-block btn-danger invisible"")
            ediVel_esp = false;
            var valor = document.getElementById(""velo_esp"").value           
        if (acao) { esp_velAsinc(valor) }        
    }

    function esp_velAsinc(valor) {
        
          var xhp = new XMLHttpRequest()
        xhp.onreadystatechange = function () {
            if (this.readyState === 4 && this.status === 200) {
                var re = this.responseText               
                }
            }
        
        xhp.open(""Get"", ""/oee/set_vel_esp?id=""+""");
            EndContext();
            BeginContext(6553, 8, false);
#line 147 "C:\DXM100 estudos\DXM.Web.Interface - zyess\DXM.Web.Interface\Views\oee\linha.cshtml"
                                           Write(Model.id);

#line default
#line hidden
            EndContext();
            BeginContext(6561, 2495, true);
            WriteLiteral(@"""+""&valor=""+valor);
        xhp.send();
    }



    var editT_p_prog = false

    function agendadoChange() {
        var valor = document.getElementById(""agendado"").value
        var temp = """"
        var temph = """"
        var tempm = """"
        if (valor.indexOf("":"")>0) {
            
            if (valor.length > 7) {
                temph = `${valor.substr(1, 1)}${valor.substr(5, 1)}`               
                tempm = valor.substr(6, 2)               
            }
            else {
                temph = valor.substr(0, 2)
                tempm = valor.substr(6, 2)                
            }            
            temp = `${temph}${tempm}`
            valor=""""
        }
        
        if (valor != """") {
            for (var x = valor.length; x < 4; x++) {
                temp = `0${temp}`
            }
           
            temp = temp + valor
           
            if (temp.length > 4) {
                temp = temp.substring(temp.length - 4, 5)
    ");
            WriteLiteral(@"        }

            temph = temp.substr(0, 2)
            tempm = temp.substr(2, 2)            
        }
        
        temp = `${temph} : ${tempm}`
       
        if (temp.length < 7) {temp=""""}
        document.getElementById(""agendado"").value = temp
        input_h_p_pro = parseInt(temph) * 60 + parseInt(tempm)
       // alert(input_h_p_pro)
    }

    function t_p_progBtnF() {
        editT_p_prog = true;
        document.getElementById(""t_p_progBtn"").setAttribute(""class"", ""btn btn-block btn-primary visible"")
        document.getElementById(""t_p_progCls"").setAttribute(""class"", ""btn btn-block btn-danger visible"")       
        document.getElementById(""agendado"").value = """" 
    }

    function salvaT_p_prog(acao) {
        document.getElementById(""t_p_progBtn"").setAttribute(""class"", ""btn btn-block btn-primary invisible"")
        document.getElementById(""t_p_progCls"").setAttribute(""class"", ""btn btn-block btn-danger invisible"")
        editT_p_prog = false;
        var valor =");
            WriteLiteral(@" document.getElementById(""agendado"").value
        if (acao) { t_p_progAsinc(valor) }
    }

    function t_p_progAsinc() {
       
          var xhp = new XMLHttpRequest()
        xhp.onreadystatechange = function () {
            if (this.readyState === 4 && this.status === 200) {
                var re = this.responseText               
                }
            }
        
        xhp.open(""Get"", ""/oee/set_t_p_prog?id="" + """);
            EndContext();
            BeginContext(9057, 8, false);
#line 221 "C:\DXM100 estudos\DXM.Web.Interface - zyess\DXM.Web.Interface\Views\oee\linha.cshtml"
                                              Write(Model.id);

#line default
#line hidden
            EndContext();
            BeginContext(9065, 496, true);
            WriteLiteral(@""" + ""&valor="" + input_h_p_pro);
        xhp.send();
    }

    function formaAsinc() {
          var valor=document.getElementById(""forma"").value  
          var xhp = new XMLHttpRequest()
          xhp.onreadystatechange = function () {
            if (this.readyState === 4 && this.status === 200) {
                var re = this.responseText   
                    document.location.reload()
                }
            }
        
        xhp.open(""Get"", ""/oee/set_forma?id=""+""");
            EndContext();
            BeginContext(9562, 8, false);
#line 235 "C:\DXM100 estudos\DXM.Web.Interface - zyess\DXM.Web.Interface\Views\oee\linha.cshtml"
                                         Write(Model.id);

#line default
#line hidden
            EndContext();
            BeginContext(9570, 1484, true);
            WriteLiteral(@"""+""&valor=""+valor);
        xhp.send();
    }

    var sectors = [{
        color: ""#c00002"",
        lo: 0,
        hi: 20,
    }, {
        color: ""#febf00"",
        lo: 20,
        hi: 40,
    }, {
        color: ""#fdf500"",
        lo: 40,
        hi: 60,
    }, {
        color: ""#92d14f"",
        lo: 60,
        hi: 80,
    }, {
        color: ""#00af50"",
        lo: 80,
        hi: 100,
    }];

    var oee = new JustGage({
        id: ""GOEE"",
        value: 100,
        min: 0,
        max: 100,
        title: ""OEE"",
        symbol: '%',
        pointer: true,
        customSectors: sectors,
        relativeGaugeSize: true
    });

    var per = new JustGage({
        id: ""Gper"",
        value: 100,
        min: 0,
        max: 100,
        title: ""Performance"",
        symbol: '%',
        pointer: true,
        customSectors: sectors,
        relativeGaugeSize: true
    });

    var q = new JustGage({
        id: ""Gq"",
        value: 100,
        min");
            WriteLiteral(@": 0,
        max: 100,
        title: ""Qualidade"",
        symbol: '%',
        pointer: true,
        customSectors: sectors,
        relativeGaugeSize: true
    });

    var dis = new JustGage({
        id: ""Gdis"",
        value: 100,
        min: 0,
        max: 100,
        title: ""Disponibilidade"",
        symbol: '%',
        pointer: true,
        customSectors: sectors,
        relativeGaugeSize: true
    });

     oee.refresh(");
            EndContext();
            BeginContext(11055, 9, false);
#line 309 "C:\DXM100 estudos\DXM.Web.Interface - zyess\DXM.Web.Interface\Views\oee\linha.cshtml"
            Write(Model.oee);

#line default
#line hidden
            EndContext();
            BeginContext(11064, 19, true);
            WriteLiteral(")\r\n    dis.refresh(");
            EndContext();
            BeginContext(11084, 9, false);
#line 310 "C:\DXM100 estudos\DXM.Web.Interface - zyess\DXM.Web.Interface\Views\oee\linha.cshtml"
           Write(Model.dis);

#line default
#line hidden
            EndContext();
            BeginContext(11093, 17, true);
            WriteLiteral(")\r\n    q.refresh(");
            EndContext();
            BeginContext(11111, 7, false);
#line 311 "C:\DXM100 estudos\DXM.Web.Interface - zyess\DXM.Web.Interface\Views\oee\linha.cshtml"
         Write(Model.q);

#line default
#line hidden
            EndContext();
            BeginContext(11118, 19, true);
            WriteLiteral(")\r\n    per.refresh(");
            EndContext();
            BeginContext(11138, 9, false);
#line 312 "C:\DXM100 estudos\DXM.Web.Interface - zyess\DXM.Web.Interface\Views\oee\linha.cshtml"
           Write(Model.per);

#line default
#line hidden
            EndContext();
            BeginContext(11147, 1631, true);
            WriteLiteral(@")

    setInterval(function () {
        getlinhas();
    }, 1000)

    function getlinhas() {
        var xhp = new XMLHttpRequest()
        xhp.onreadystatechange = function () {
            if (this.readyState === 4 && this.status === 200) {
                var re = this.responseText
                data = JSON.parse(re);                
                if (data.estado == ""DXM OffLine"") {
                    document.location.href = ""/oee/offline"";
                }
                else {
                    oee.refresh(data.oee)
                    dis.refresh(data.dis)
                    q.refresh(data.q)
                    per.refresh(data.per)
                    document.getElementById(""estado"").innerHTML = data.estado;
                    document.getElementById(""operando"").value = `${parseInt(data.t_prod / 60)} : ${data.t_prod % 60}`
                    document.getElementById(""parado"").value = `${parseInt(data.t_par / 60)} : ${data.t_par%60}`
                    if (!editT_");
            WriteLiteral(@"p_prog) { document.getElementById(""agendado"").value = `${parseInt(data.t_p_prog / 60)} : ${data.t_p_prog % 60}` }
                    document.getElementById(""produzindo"").value = data.cont_in
                    document.getElementById(""aprovado"").value = data.cont_out
                    document.getElementById(""velocidade"").value = data.vel_atu + "" p/min""
                    if (!ediVel_esp) { document.getElementById(""velo_esp"").value = data.vel_esp + "" p/min""}
                    

                    }
                }

            }
        
        xhp.open(""Get"", ""/oee/get_linha/");
            EndContext();
            BeginContext(12779, 8, false);
#line 347 "C:\DXM100 estudos\DXM.Web.Interface - zyess\DXM.Web.Interface\Views\oee\linha.cshtml"
                                   Write(Model.id);

#line default
#line hidden
            EndContext();
            BeginContext(12787, 146, true);
            WriteLiteral("\");\r\n        xhp.send();\r\n    }\r\n</script>\r\n\r\n<style>\r\n    .gauge {\r\n        min-width: 250px;\r\n        max-width: 300px;\r\n    }\r\n</style>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DXM.OEE.Linha> Html { get; private set; }
    }
}
#pragma warning restore 1591
