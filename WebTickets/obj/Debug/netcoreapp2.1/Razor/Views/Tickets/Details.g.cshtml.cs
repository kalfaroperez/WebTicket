#pragma checksum "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eabba60c04153eae16d0eb00e8007a9508085bae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tickets_Details), @"mvc.1.0.view", @"/Views/Tickets/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tickets/Details.cshtml", typeof(AspNetCore.Views_Tickets_Details))]
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
#line 1 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\_ViewImports.cshtml"
using WebTickets;

#line default
#line hidden
#line 2 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\_ViewImports.cshtml"
using WebTickets.ViewModels;

#line default
#line hidden
#line 3 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\_ViewImports.cshtml"
using Model.DB_Model;

#line default
#line hidden
#line 4 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 5 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\_ViewImports.cshtml"
using Model.Auth;

#line default
#line hidden
#line 6 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\_ViewImports.cshtml"
using Model.Custom;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eabba60c04153eae16d0eb00e8007a9508085bae", @"/Views/Tickets/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2889cc5cc431ba8747eb733b332e56d1a70baf04", @"/Views/_ViewImports.cshtml")]
    public class Views_Tickets_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Model.DB_Model.Ticket>
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
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(122, 120, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Ticket</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(243, 49, false);
#line 15 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Numero_Ticket));

#line default
#line hidden
            EndContext();
            BeginContext(292, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(336, 45, false);
#line 18 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Numero_Ticket));

#line default
#line hidden
            EndContext();
            BeginContext(381, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(425, 41, false);
#line 21 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Fecha));

#line default
#line hidden
            EndContext();
            BeginContext(466, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(510, 37, false);
#line 24 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Fecha));

#line default
#line hidden
            EndContext();
            BeginContext(547, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(591, 43, false);
#line 27 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Privado));

#line default
#line hidden
            EndContext();
            BeginContext(634, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(678, 39, false);
#line 30 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Privado));

#line default
#line hidden
            EndContext();
            BeginContext(717, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(761, 47, false);
#line 33 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Operador_Id));

#line default
#line hidden
            EndContext();
            BeginContext(808, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(852, 43, false);
#line 36 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Operador_Id));

#line default
#line hidden
            EndContext();
            BeginContext(895, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(939, 54, false);
#line 39 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Operador_Sector_Id));

#line default
#line hidden
            EndContext();
            BeginContext(993, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1037, 50, false);
#line 42 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Operador_Sector_Id));

#line default
#line hidden
            EndContext();
            BeginContext(1087, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1131, 46, false);
#line 45 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Usuario_Id));

#line default
#line hidden
            EndContext();
            BeginContext(1177, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1221, 42, false);
#line 48 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Usuario_Id));

#line default
#line hidden
            EndContext();
            BeginContext(1263, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1307, 51, false);
#line 51 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombre_completo));

#line default
#line hidden
            EndContext();
            BeginContext(1358, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1402, 47, false);
#line 54 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nombre_completo));

#line default
#line hidden
            EndContext();
            BeginContext(1449, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1493, 43, false);
#line 57 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Area_Id));

#line default
#line hidden
            EndContext();
            BeginContext(1536, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1580, 39, false);
#line 60 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Area_Id));

#line default
#line hidden
            EndContext();
            BeginContext(1619, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1663, 45, false);
#line 63 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Ubicacion));

#line default
#line hidden
            EndContext();
            BeginContext(1708, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1752, 41, false);
#line 66 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ubicacion));

#line default
#line hidden
            EndContext();
            BeginContext(1793, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1837, 44, false);
#line 69 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Telefono));

#line default
#line hidden
            EndContext();
            BeginContext(1881, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1925, 40, false);
#line 72 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Telefono));

#line default
#line hidden
            EndContext();
            BeginContext(1965, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2009, 41, false);
#line 75 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EMail));

#line default
#line hidden
            EndContext();
            BeginContext(2050, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2094, 37, false);
#line 78 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.EMail));

#line default
#line hidden
            EndContext();
            BeginContext(2131, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2175, 46, false);
#line 81 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Asignado_A));

#line default
#line hidden
            EndContext();
            BeginContext(2221, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2265, 42, false);
#line 84 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Asignado_A));

#line default
#line hidden
            EndContext();
            BeginContext(2307, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2351, 53, false);
#line 87 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Asignado_A_Sector));

#line default
#line hidden
            EndContext();
            BeginContext(2404, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2448, 49, false);
#line 90 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Asignado_A_Sector));

#line default
#line hidden
            EndContext();
            BeginContext(2497, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2541, 45, false);
#line 93 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Prioridad));

#line default
#line hidden
            EndContext();
            BeginContext(2586, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2630, 41, false);
#line 96 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Prioridad));

#line default
#line hidden
            EndContext();
            BeginContext(2671, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2715, 45, false);
#line 99 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Incidente));

#line default
#line hidden
            EndContext();
            BeginContext(2760, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2804, 41, false);
#line 102 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Incidente));

#line default
#line hidden
            EndContext();
            BeginContext(2845, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2889, 43, false);
#line 105 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Proceso));

#line default
#line hidden
            EndContext();
            BeginContext(2932, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2976, 39, false);
#line 108 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Proceso));

#line default
#line hidden
            EndContext();
            BeginContext(3015, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3059, 48, false);
#line 111 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tipo_Trabajo));

#line default
#line hidden
            EndContext();
            BeginContext(3107, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3151, 44, false);
#line 114 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tipo_Trabajo));

#line default
#line hidden
            EndContext();
            BeginContext(3195, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3239, 45, false);
#line 117 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id_Planta));

#line default
#line hidden
            EndContext();
            BeginContext(3284, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3328, 41, false);
#line 120 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id_Planta));

#line default
#line hidden
            EndContext();
            BeginContext(3369, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3413, 50, false);
#line 123 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id_EquipoPrinc));

#line default
#line hidden
            EndContext();
            BeginContext(3463, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3507, 46, false);
#line 126 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id_EquipoPrinc));

#line default
#line hidden
            EndContext();
            BeginContext(3553, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3597, 48, false);
#line 129 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id_EquipoSec));

#line default
#line hidden
            EndContext();
            BeginContext(3645, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3689, 44, false);
#line 132 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id_EquipoSec));

#line default
#line hidden
            EndContext();
            BeginContext(3733, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3777, 49, false);
#line 135 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id_Componente));

#line default
#line hidden
            EndContext();
            BeginContext(3826, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3870, 45, false);
#line 138 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id_Componente));

#line default
#line hidden
            EndContext();
            BeginContext(3915, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3959, 42, false);
#line 141 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(4001, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4045, 38, false);
#line 144 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(4083, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4127, 48, false);
#line 147 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Calificacion));

#line default
#line hidden
            EndContext();
            BeginContext(4175, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4219, 44, false);
#line 150 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Calificacion));

#line default
#line hidden
            EndContext();
            BeginContext(4263, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4307, 55, false);
#line 153 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Fecha_Ultimo_Estado));

#line default
#line hidden
            EndContext();
            BeginContext(4362, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4406, 51, false);
#line 156 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Fecha_Ultimo_Estado));

#line default
#line hidden
            EndContext();
            BeginContext(4457, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4501, 49, false);
#line 159 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Fecha_Entrega));

#line default
#line hidden
            EndContext();
            BeginContext(4550, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4594, 45, false);
#line 162 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Fecha_Entrega));

#line default
#line hidden
            EndContext();
            BeginContext(4639, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4683, 58, false);
#line 165 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Operador_Ultimo_Estado));

#line default
#line hidden
            EndContext();
            BeginContext(4741, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4785, 54, false);
#line 168 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Operador_Ultimo_Estado));

#line default
#line hidden
            EndContext();
            BeginContext(4839, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4883, 43, false);
#line 171 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Adjunto));

#line default
#line hidden
            EndContext();
            BeginContext(4926, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4970, 39, false);
#line 174 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Adjunto));

#line default
#line hidden
            EndContext();
            BeginContext(5009, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5053, 48, false);
#line 177 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tipo_Adjunto));

#line default
#line hidden
            EndContext();
            BeginContext(5101, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5145, 44, false);
#line 180 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tipo_Adjunto));

#line default
#line hidden
            EndContext();
            BeginContext(5189, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5233, 48, false);
#line 183 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Ruta_Adjunto));

#line default
#line hidden
            EndContext();
            BeginContext(5281, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5325, 44, false);
#line 186 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ruta_Adjunto));

#line default
#line hidden
            EndContext();
            BeginContext(5369, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5413, 50, false);
#line 189 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombre_Adjunto));

#line default
#line hidden
            EndContext();
            BeginContext(5463, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5507, 46, false);
#line 192 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nombre_Adjunto));

#line default
#line hidden
            EndContext();
            BeginContext(5553, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5597, 47, false);
#line 195 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Insert_Oper));

#line default
#line hidden
            EndContext();
            BeginContext(5644, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5688, 43, false);
#line 198 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Insert_Oper));

#line default
#line hidden
            EndContext();
            BeginContext(5731, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5775, 51, false);
#line 201 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Insert_Datetime));

#line default
#line hidden
            EndContext();
            BeginContext(5826, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5870, 47, false);
#line 204 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Insert_Datetime));

#line default
#line hidden
            EndContext();
            BeginContext(5917, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5961, 47, false);
#line 207 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Update_Oper));

#line default
#line hidden
            EndContext();
            BeginContext(6008, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(6052, 43, false);
#line 210 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Update_Oper));

#line default
#line hidden
            EndContext();
            BeginContext(6095, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(6139, 51, false);
#line 213 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Update_Datetime));

#line default
#line hidden
            EndContext();
            BeginContext(6190, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(6234, 47, false);
#line 216 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Update_Datetime));

#line default
#line hidden
            EndContext();
            BeginContext(6281, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(6328, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0783559c52d14f3eaaa2d357c25220ec", async() => {
                BeginContext(6374, 4, true);
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
#line 221 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Tickets\Details.cshtml"
                           WriteLiteral(Model.Id);

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
            BeginContext(6382, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(6390, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7dc4edcbf46f4ab3b883debf82cb75bc", async() => {
                BeginContext(6412, 12, true);
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
            BeginContext(6428, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Model.DB_Model.Ticket> Html { get; private set; }
    }
}
#pragma warning restore 1591
