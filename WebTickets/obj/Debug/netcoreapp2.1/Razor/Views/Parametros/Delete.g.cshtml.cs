#pragma checksum "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac003af3521dfb88b2049dac378c3d48e8db8872"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Parametros_Delete), @"mvc.1.0.view", @"/Views/Parametros/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Parametros/Delete.cshtml", typeof(AspNetCore.Views_Parametros_Delete))]
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
#line 1 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\_ViewImports.cshtml"
using WebTickets;

#line default
#line hidden
#line 2 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\_ViewImports.cshtml"
using WebTickets.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\_ViewImports.cshtml"
using Model.DB_Model;

#line default
#line hidden
#line 4 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 5 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\_ViewImports.cshtml"
using Model.Auth;

#line default
#line hidden
#line 6 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\_ViewImports.cshtml"
using Model.Custom;

#line default
#line hidden
#line 7 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\_ViewImports.cshtml"
using WebTickets.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac003af3521dfb88b2049dac378c3d48e8db8872", @"/Views/Parametros/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c713a1b51c4402ae1ef8a5d9b2ef8c6e67fa362", @"/Views/_ViewImports.cshtml")]
    public class Views_Parametros_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Model.DB_Model.Parametros>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(125, 171, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Parametros</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(297, 46, false);
#line 16 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ValidezPsw));

#line default
#line hidden
            EndContext();
            BeginContext(343, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(387, 42, false);
#line 19 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ValidezPsw));

#line default
#line hidden
            EndContext();
            BeginContext(429, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(473, 43, false);
#line 22 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DiasPsw));

#line default
#line hidden
            EndContext();
            BeginContext(516, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(560, 39, false);
#line 25 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DiasPsw));

#line default
#line hidden
            EndContext();
            BeginContext(599, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(643, 50, false);
#line 28 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MaxLinesScreen));

#line default
#line hidden
            EndContext();
            BeginContext(693, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(737, 46, false);
#line 31 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MaxLinesScreen));

#line default
#line hidden
            EndContext();
            BeginContext(783, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(827, 50, false);
#line 34 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MaxLinesExport));

#line default
#line hidden
            EndContext();
            BeginContext(877, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(921, 46, false);
#line 37 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MaxLinesExport));

#line default
#line hidden
            EndContext();
            BeginContext(967, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1011, 45, false);
#line 40 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MaxDifMin));

#line default
#line hidden
            EndContext();
            BeginContext(1056, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1100, 41, false);
#line 43 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MaxDifMin));

#line default
#line hidden
            EndContext();
            BeginContext(1141, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1185, 45, false);
#line 46 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MaxAttach));

#line default
#line hidden
            EndContext();
            BeginContext(1230, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1274, 41, false);
#line 49 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MaxAttach));

#line default
#line hidden
            EndContext();
            BeginContext(1315, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1359, 48, false);
#line 52 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AssignTicket));

#line default
#line hidden
            EndContext();
            BeginContext(1407, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1451, 44, false);
#line 55 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AssignTicket));

#line default
#line hidden
            EndContext();
            BeginContext(1495, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1539, 51, false);
#line 58 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FromUserRequest));

#line default
#line hidden
            EndContext();
            BeginContext(1590, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1634, 47, false);
#line 61 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FromUserRequest));

#line default
#line hidden
            EndContext();
            BeginContext(1681, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1725, 59, false);
#line 64 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SubcarpetaAdjuntoTicket));

#line default
#line hidden
            EndContext();
            BeginContext(1784, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1828, 55, false);
#line 67 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SubcarpetaAdjuntoTicket));

#line default
#line hidden
            EndContext();
            BeginContext(1883, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1927, 61, false);
#line 70 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SubcarpetaAdjuntoFichaTec));

#line default
#line hidden
            EndContext();
            BeginContext(1988, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2032, 57, false);
#line 73 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SubcarpetaAdjuntoFichaTec));

#line default
#line hidden
            EndContext();
            BeginContext(2089, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2133, 47, false);
#line 76 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FromUserPsw));

#line default
#line hidden
            EndContext();
            BeginContext(2180, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2224, 43, false);
#line 79 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FromUserPsw));

#line default
#line hidden
            EndContext();
            BeginContext(2267, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2311, 50, false);
#line 82 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ContactDefault));

#line default
#line hidden
            EndContext();
            BeginContext(2361, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2405, 46, false);
#line 85 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ContactDefault));

#line default
#line hidden
            EndContext();
            BeginContext(2451, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2495, 50, false);
#line 88 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ProcessDefault));

#line default
#line hidden
            EndContext();
            BeginContext(2545, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2589, 46, false);
#line 91 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ProcessDefault));

#line default
#line hidden
            EndContext();
            BeginContext(2635, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2679, 48, false);
#line 94 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.StateDefault));

#line default
#line hidden
            EndContext();
            BeginContext(2727, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2771, 44, false);
#line 97 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.StateDefault));

#line default
#line hidden
            EndContext();
            BeginContext(2815, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2859, 46, false);
#line 100 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.StateAlert));

#line default
#line hidden
            EndContext();
            BeginContext(2905, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2949, 42, false);
#line 103 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.StateAlert));

#line default
#line hidden
            EndContext();
            BeginContext(2991, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3035, 51, false);
#line 106 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MainScreenState));

#line default
#line hidden
            EndContext();
            BeginContext(3086, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3130, 47, false);
#line 109 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MainScreenState));

#line default
#line hidden
            EndContext();
            BeginContext(3177, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3221, 46, false);
#line 112 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DateFormat));

#line default
#line hidden
            EndContext();
            BeginContext(3267, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3311, 42, false);
#line 115 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DateFormat));

#line default
#line hidden
            EndContext();
            BeginContext(3353, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3397, 39, false);
#line 118 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Pen));

#line default
#line hidden
            EndContext();
            BeginContext(3436, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3480, 35, false);
#line 121 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Pen));

#line default
#line hidden
            EndContext();
            BeginContext(3515, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3559, 39, false);
#line 124 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Pas));

#line default
#line hidden
            EndContext();
            BeginContext(3598, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3642, 35, false);
#line 127 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Pas));

#line default
#line hidden
            EndContext();
            BeginContext(3677, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3721, 39, false);
#line 130 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Can));

#line default
#line hidden
            EndContext();
            BeginContext(3760, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3804, 35, false);
#line 133 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Can));

#line default
#line hidden
            EndContext();
            BeginContext(3839, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3883, 46, false);
#line 136 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.InsertOper));

#line default
#line hidden
            EndContext();
            BeginContext(3929, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3973, 42, false);
#line 139 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.InsertOper));

#line default
#line hidden
            EndContext();
            BeginContext(4015, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4059, 50, false);
#line 142 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.InsertDatetime));

#line default
#line hidden
            EndContext();
            BeginContext(4109, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4153, 46, false);
#line 145 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.InsertDatetime));

#line default
#line hidden
            EndContext();
            BeginContext(4199, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4243, 46, false);
#line 148 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdateOper));

#line default
#line hidden
            EndContext();
            BeginContext(4289, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4333, 42, false);
#line 151 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UpdateOper));

#line default
#line hidden
            EndContext();
            BeginContext(4375, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4419, 50, false);
#line 154 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdateDatetime));

#line default
#line hidden
            EndContext();
            BeginContext(4469, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4513, 46, false);
#line 157 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UpdateDatetime));

#line default
#line hidden
            EndContext();
            BeginContext(4559, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(4597, 217, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4effde19c7b240e9b0fd775b66e93d04", async() => {
                BeginContext(4623, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(4633, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "32f1aad5c8584ff2b3173fa23576387d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 162 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Parametros\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ParametrosId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4679, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(4763, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c33d7ad7cb4e4cf8a14db528446faed1", async() => {
                    BeginContext(4785, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4801, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4814, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Model.DB_Model.Parametros> Html { get; private set; }
    }
}
#pragma warning restore 1591
