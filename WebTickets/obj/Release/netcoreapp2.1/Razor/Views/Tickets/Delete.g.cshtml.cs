#pragma checksum "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c419ac1ab6fcec93aeabe1981575cff6c0bb14f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tickets_Delete), @"mvc.1.0.view", @"/Views/Tickets/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tickets/Delete.cshtml", typeof(AspNetCore.Views_Tickets_Delete))]
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
#line 1 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\_ViewImports.cshtml"
using WebTickets;

#line default
#line hidden
#line 2 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\_ViewImports.cshtml"
using WebTickets.ViewModels;

#line default
#line hidden
#line 3 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\_ViewImports.cshtml"
using Model.DB_Model;

#line default
#line hidden
#line 4 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 5 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\_ViewImports.cshtml"
using Model.Auth;

#line default
#line hidden
#line 6 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\_ViewImports.cshtml"
using Model.Custom;

#line default
#line hidden
#line 7 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\_ViewImports.cshtml"
using WebTickets.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c419ac1ab6fcec93aeabe1981575cff6c0bb14f", @"/Views/Tickets/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c713a1b51c4402ae1ef8a5d9b2ef8c6e67fa362", @"/Views/_ViewImports.cshtml")]
    public class Views_Tickets_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Model.DB_Model.Ticket>
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
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(121, 167, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Ticket</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(289, 49, false);
#line 16 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Numero_Ticket));

#line default
#line hidden
            EndContext();
            BeginContext(338, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(382, 45, false);
#line 19 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Numero_Ticket));

#line default
#line hidden
            EndContext();
            BeginContext(427, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(471, 41, false);
#line 22 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Fecha));

#line default
#line hidden
            EndContext();
            BeginContext(512, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(556, 37, false);
#line 25 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Fecha));

#line default
#line hidden
            EndContext();
            BeginContext(593, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(637, 43, false);
#line 28 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Privado));

#line default
#line hidden
            EndContext();
            BeginContext(680, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(724, 39, false);
#line 31 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Privado));

#line default
#line hidden
            EndContext();
            BeginContext(763, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(807, 47, false);
#line 34 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Operador_Id));

#line default
#line hidden
            EndContext();
            BeginContext(854, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(898, 43, false);
#line 37 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Operador_Id));

#line default
#line hidden
            EndContext();
            BeginContext(941, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(985, 54, false);
#line 40 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Operador_Sector_Id));

#line default
#line hidden
            EndContext();
            BeginContext(1039, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1083, 50, false);
#line 43 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Operador_Sector_Id));

#line default
#line hidden
            EndContext();
            BeginContext(1133, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1177, 46, false);
#line 46 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Usuario_Id));

#line default
#line hidden
            EndContext();
            BeginContext(1223, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1267, 42, false);
#line 49 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Usuario_Id));

#line default
#line hidden
            EndContext();
            BeginContext(1309, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1353, 51, false);
#line 52 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombre_completo));

#line default
#line hidden
            EndContext();
            BeginContext(1404, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1448, 47, false);
#line 55 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Nombre_completo));

#line default
#line hidden
            EndContext();
            BeginContext(1495, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1539, 43, false);
#line 58 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Area_Id));

#line default
#line hidden
            EndContext();
            BeginContext(1582, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1626, 39, false);
#line 61 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Area_Id));

#line default
#line hidden
            EndContext();
            BeginContext(1665, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1709, 45, false);
#line 64 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Ubicacion));

#line default
#line hidden
            EndContext();
            BeginContext(1754, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1798, 41, false);
#line 67 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Ubicacion));

#line default
#line hidden
            EndContext();
            BeginContext(1839, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1883, 44, false);
#line 70 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Telefono));

#line default
#line hidden
            EndContext();
            BeginContext(1927, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1971, 40, false);
#line 73 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Telefono));

#line default
#line hidden
            EndContext();
            BeginContext(2011, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2055, 41, false);
#line 76 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EMail));

#line default
#line hidden
            EndContext();
            BeginContext(2096, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2140, 37, false);
#line 79 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EMail));

#line default
#line hidden
            EndContext();
            BeginContext(2177, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2221, 46, false);
#line 82 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Asignado_A));

#line default
#line hidden
            EndContext();
            BeginContext(2267, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2311, 42, false);
#line 85 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Asignado_A));

#line default
#line hidden
            EndContext();
            BeginContext(2353, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2397, 53, false);
#line 88 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Asignado_A_Sector));

#line default
#line hidden
            EndContext();
            BeginContext(2450, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2494, 49, false);
#line 91 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Asignado_A_Sector));

#line default
#line hidden
            EndContext();
            BeginContext(2543, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2587, 45, false);
#line 94 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Prioridad));

#line default
#line hidden
            EndContext();
            BeginContext(2632, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2676, 41, false);
#line 97 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Prioridad));

#line default
#line hidden
            EndContext();
            BeginContext(2717, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2761, 45, false);
#line 100 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Incidente));

#line default
#line hidden
            EndContext();
            BeginContext(2806, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2850, 41, false);
#line 103 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Incidente));

#line default
#line hidden
            EndContext();
            BeginContext(2891, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2935, 43, false);
#line 106 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Proceso));

#line default
#line hidden
            EndContext();
            BeginContext(2978, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3022, 39, false);
#line 109 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Proceso));

#line default
#line hidden
            EndContext();
            BeginContext(3061, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3105, 48, false);
#line 112 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Tipo_Trabajo));

#line default
#line hidden
            EndContext();
            BeginContext(3153, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3197, 44, false);
#line 115 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Tipo_Trabajo));

#line default
#line hidden
            EndContext();
            BeginContext(3241, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3285, 45, false);
#line 118 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Id_Planta));

#line default
#line hidden
            EndContext();
            BeginContext(3330, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3374, 41, false);
#line 121 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Id_Planta));

#line default
#line hidden
            EndContext();
            BeginContext(3415, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3459, 50, false);
#line 124 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Id_EquipoPrinc));

#line default
#line hidden
            EndContext();
            BeginContext(3509, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3553, 46, false);
#line 127 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Id_EquipoPrinc));

#line default
#line hidden
            EndContext();
            BeginContext(3599, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3643, 48, false);
#line 130 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Id_EquipoSec));

#line default
#line hidden
            EndContext();
            BeginContext(3691, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3735, 44, false);
#line 133 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Id_EquipoSec));

#line default
#line hidden
            EndContext();
            BeginContext(3779, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3823, 49, false);
#line 136 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Id_Componente));

#line default
#line hidden
            EndContext();
            BeginContext(3872, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3916, 45, false);
#line 139 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Id_Componente));

#line default
#line hidden
            EndContext();
            BeginContext(3961, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4005, 42, false);
#line 142 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(4047, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4091, 38, false);
#line 145 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(4129, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4173, 48, false);
#line 148 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Calificacion));

#line default
#line hidden
            EndContext();
            BeginContext(4221, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4265, 44, false);
#line 151 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Calificacion));

#line default
#line hidden
            EndContext();
            BeginContext(4309, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4353, 55, false);
#line 154 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Fecha_Ultimo_Estado));

#line default
#line hidden
            EndContext();
            BeginContext(4408, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4452, 51, false);
#line 157 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Fecha_Ultimo_Estado));

#line default
#line hidden
            EndContext();
            BeginContext(4503, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4547, 49, false);
#line 160 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Fecha_Entrega));

#line default
#line hidden
            EndContext();
            BeginContext(4596, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4640, 45, false);
#line 163 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Fecha_Entrega));

#line default
#line hidden
            EndContext();
            BeginContext(4685, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4729, 58, false);
#line 166 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Operador_Ultimo_Estado));

#line default
#line hidden
            EndContext();
            BeginContext(4787, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(4831, 54, false);
#line 169 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Operador_Ultimo_Estado));

#line default
#line hidden
            EndContext();
            BeginContext(4885, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(4929, 43, false);
#line 172 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Adjunto));

#line default
#line hidden
            EndContext();
            BeginContext(4972, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5016, 39, false);
#line 175 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Adjunto));

#line default
#line hidden
            EndContext();
            BeginContext(5055, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5099, 48, false);
#line 178 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Tipo_Adjunto));

#line default
#line hidden
            EndContext();
            BeginContext(5147, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5191, 44, false);
#line 181 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Tipo_Adjunto));

#line default
#line hidden
            EndContext();
            BeginContext(5235, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5279, 48, false);
#line 184 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Ruta_Adjunto));

#line default
#line hidden
            EndContext();
            BeginContext(5327, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5371, 44, false);
#line 187 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Ruta_Adjunto));

#line default
#line hidden
            EndContext();
            BeginContext(5415, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5459, 50, false);
#line 190 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombre_Adjunto));

#line default
#line hidden
            EndContext();
            BeginContext(5509, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5553, 46, false);
#line 193 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Nombre_Adjunto));

#line default
#line hidden
            EndContext();
            BeginContext(5599, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5643, 47, false);
#line 196 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Insert_Oper));

#line default
#line hidden
            EndContext();
            BeginContext(5690, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5734, 43, false);
#line 199 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Insert_Oper));

#line default
#line hidden
            EndContext();
            BeginContext(5777, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(5821, 51, false);
#line 202 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Insert_Datetime));

#line default
#line hidden
            EndContext();
            BeginContext(5872, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(5916, 47, false);
#line 205 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Insert_Datetime));

#line default
#line hidden
            EndContext();
            BeginContext(5963, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(6007, 47, false);
#line 208 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Update_Oper));

#line default
#line hidden
            EndContext();
            BeginContext(6054, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(6098, 43, false);
#line 211 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Update_Oper));

#line default
#line hidden
            EndContext();
            BeginContext(6141, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(6185, 51, false);
#line 214 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Update_Datetime));

#line default
#line hidden
            EndContext();
            BeginContext(6236, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(6280, 47, false);
#line 217 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Update_Datetime));

#line default
#line hidden
            EndContext();
            BeginContext(6327, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(6365, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "740ed27e675a418dbc8d8bf149fd3f2f", async() => {
                BeginContext(6391, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(6401, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ca4839545ffc4b879901cfa5655bfeab", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 222 "D:\Users\kalfaro\source\repos\WebTicket\WebTickets\Views\Tickets\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

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
                BeginContext(6437, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(6521, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98c5585eb6044ab5b74371f25ab57b1e", async() => {
                    BeginContext(6543, 12, true);
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
                BeginContext(6559, 6, true);
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
            BeginContext(6572, 10, true);
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
