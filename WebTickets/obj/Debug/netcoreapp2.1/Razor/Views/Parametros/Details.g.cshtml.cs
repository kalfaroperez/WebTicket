#pragma checksum "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e1d9c8553ae69e7f38cffadb304f788070a1045"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Parametros_Details), @"mvc.1.0.view", @"/Views/Parametros/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Parametros/Details.cshtml", typeof(AspNetCore.Views_Parametros_Details))]
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
#line 1 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\_ViewImports.cshtml"
using WebTickets;

#line default
#line hidden
#line 2 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\_ViewImports.cshtml"
using WebTickets.ViewModels;

#line default
#line hidden
#line 3 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\_ViewImports.cshtml"
using Model.DB_Model;

#line default
#line hidden
#line 4 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 5 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\_ViewImports.cshtml"
using Model.Auth;

#line default
#line hidden
#line 6 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\_ViewImports.cshtml"
using Model.Custom;

#line default
#line hidden
#line 7 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\_ViewImports.cshtml"
using WebTickets.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e1d9c8553ae69e7f38cffadb304f788070a1045", @"/Views/Parametros/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c713a1b51c4402ae1ef8a5d9b2ef8c6e67fa362", @"/Views/_ViewImports.cshtml")]
    public class Views_Parametros_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Model.DB_Model.Parametros>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(126, 124, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Parametros</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(251, 46, false);
#line 15 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ValidezPsw));

#line default
#line hidden
            EndContext();
            BeginContext(297, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(341, 42, false);
#line 18 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayFor(model => model.ValidezPsw));

#line default
#line hidden
            EndContext();
            BeginContext(383, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(427, 43, false);
#line 21 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DiasPsw));

#line default
#line hidden
            EndContext();
            BeginContext(470, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(514, 39, false);
#line 24 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayFor(model => model.DiasPsw));

#line default
#line hidden
            EndContext();
            BeginContext(553, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(597, 50, false);
#line 27 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaxLinesScreen));

#line default
#line hidden
            EndContext();
            BeginContext(647, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(691, 46, false);
#line 30 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaxLinesScreen));

#line default
#line hidden
            EndContext();
            BeginContext(737, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(781, 50, false);
#line 33 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaxLinesExport));

#line default
#line hidden
            EndContext();
            BeginContext(831, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(875, 46, false);
#line 36 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaxLinesExport));

#line default
#line hidden
            EndContext();
            BeginContext(921, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(965, 45, false);
#line 39 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaxDifMin));

#line default
#line hidden
            EndContext();
            BeginContext(1010, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1054, 41, false);
#line 42 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaxDifMin));

#line default
#line hidden
            EndContext();
            BeginContext(1095, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1139, 45, false);
#line 45 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaxAttach));

#line default
#line hidden
            EndContext();
            BeginContext(1184, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1228, 41, false);
#line 48 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaxAttach));

#line default
#line hidden
            EndContext();
            BeginContext(1269, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1313, 48, false);
#line 51 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AssignTicket));

#line default
#line hidden
            EndContext();
            BeginContext(1361, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1405, 44, false);
#line 54 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayFor(model => model.AssignTicket));

#line default
#line hidden
            EndContext();
            BeginContext(1449, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1493, 51, false);
#line 57 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FromUserRequest));

#line default
#line hidden
            EndContext();
            BeginContext(1544, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1588, 47, false);
#line 60 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayFor(model => model.FromUserRequest));

#line default
#line hidden
            EndContext();
            BeginContext(1635, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1679, 59, false);
#line 63 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SubcarpetaAdjuntoTicket));

#line default
#line hidden
            EndContext();
            BeginContext(1738, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1782, 55, false);
#line 66 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayFor(model => model.SubcarpetaAdjuntoTicket));

#line default
#line hidden
            EndContext();
            BeginContext(1837, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1881, 61, false);
#line 69 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SubcarpetaAdjuntoFichaTec));

#line default
#line hidden
            EndContext();
            BeginContext(1942, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1986, 57, false);
#line 72 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayFor(model => model.SubcarpetaAdjuntoFichaTec));

#line default
#line hidden
            EndContext();
            BeginContext(2043, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2087, 47, false);
#line 75 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FromUserPsw));

#line default
#line hidden
            EndContext();
            BeginContext(2134, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2178, 43, false);
#line 78 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayFor(model => model.FromUserPsw));

#line default
#line hidden
            EndContext();
            BeginContext(2221, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2265, 50, false);
#line 81 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ContactDefault));

#line default
#line hidden
            EndContext();
            BeginContext(2315, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2359, 46, false);
#line 84 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayFor(model => model.ContactDefault));

#line default
#line hidden
            EndContext();
            BeginContext(2405, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2449, 50, false);
#line 87 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProcessDefault));

#line default
#line hidden
            EndContext();
            BeginContext(2499, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2543, 46, false);
#line 90 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProcessDefault));

#line default
#line hidden
            EndContext();
            BeginContext(2589, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2633, 48, false);
#line 93 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StateDefault));

#line default
#line hidden
            EndContext();
            BeginContext(2681, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2725, 44, false);
#line 96 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayFor(model => model.StateDefault));

#line default
#line hidden
            EndContext();
            BeginContext(2769, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2813, 46, false);
#line 99 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StateAlert));

#line default
#line hidden
            EndContext();
            BeginContext(2859, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2903, 42, false);
#line 102 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayFor(model => model.StateAlert));

#line default
#line hidden
            EndContext();
            BeginContext(2945, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2989, 51, false);
#line 105 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MainScreenState));

#line default
#line hidden
            EndContext();
            BeginContext(3040, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3084, 47, false);
#line 108 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayFor(model => model.MainScreenState));

#line default
#line hidden
            EndContext();
            BeginContext(3131, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3175, 46, false);
#line 111 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateFormat));

#line default
#line hidden
            EndContext();
            BeginContext(3221, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3265, 42, false);
#line 114 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateFormat));

#line default
#line hidden
            EndContext();
            BeginContext(3307, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3351, 39, false);
#line 117 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pen));

#line default
#line hidden
            EndContext();
            BeginContext(3390, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3434, 35, false);
#line 120 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pen));

#line default
#line hidden
            EndContext();
            BeginContext(3469, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3513, 39, false);
#line 123 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pas));

#line default
#line hidden
            EndContext();
            BeginContext(3552, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3596, 35, false);
#line 126 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pas));

#line default
#line hidden
            EndContext();
            BeginContext(3631, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3675, 39, false);
#line 129 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Can));

#line default
#line hidden
            EndContext();
            BeginContext(3714, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3758, 35, false);
#line 132 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayFor(model => model.Can));

#line default
#line hidden
            EndContext();
            BeginContext(3793, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3837, 46, false);
#line 135 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.InsertOper));

#line default
#line hidden
            EndContext();
            BeginContext(3883, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3927, 42, false);
#line 138 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayFor(model => model.InsertOper));

#line default
#line hidden
            EndContext();
            BeginContext(3969, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4013, 50, false);
#line 141 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.InsertDatetime));

#line default
#line hidden
            EndContext();
            BeginContext(4063, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4107, 46, false);
#line 144 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayFor(model => model.InsertDatetime));

#line default
#line hidden
            EndContext();
            BeginContext(4153, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4197, 46, false);
#line 147 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdateOper));

#line default
#line hidden
            EndContext();
            BeginContext(4243, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4287, 42, false);
#line 150 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayFor(model => model.UpdateOper));

#line default
#line hidden
            EndContext();
            BeginContext(4329, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4373, 50, false);
#line 153 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdateDatetime));

#line default
#line hidden
            EndContext();
            BeginContext(4423, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4467, 46, false);
#line 156 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
       Write(Html.DisplayFor(model => model.UpdateDatetime));

#line default
#line hidden
            EndContext();
            BeginContext(4513, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(4560, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f4660471fc44655b232a4039de4fb33", async() => {
                BeginContext(4616, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 161 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Parametros\Details.cshtml"
                           WriteLiteral(Model.ParametrosId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4624, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(4632, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe9a47bfa4a340d0bff0b5e85f00d0e3", async() => {
                BeginContext(4654, 12, true);
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
            BeginContext(4670, 10, true);
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
