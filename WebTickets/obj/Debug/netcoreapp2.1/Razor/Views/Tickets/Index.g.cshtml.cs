#pragma checksum "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Tickets\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f633c7db68e508b9dc59af971d555c72fd2aae8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tickets_Index), @"mvc.1.0.view", @"/Views/Tickets/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tickets/Index.cshtml", typeof(AspNetCore.Views_Tickets_Index))]
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
#line 1 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\_ViewImports.cshtml"
using WebTickets;

#line default
#line hidden
#line 2 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\_ViewImports.cshtml"
using WebTickets.ViewModels;

#line default
#line hidden
#line 3 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\_ViewImports.cshtml"
using Model.DB_Model;

#line default
#line hidden
#line 4 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 5 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\_ViewImports.cshtml"
using Model.Auth;

#line default
#line hidden
#line 6 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\_ViewImports.cshtml"
using Model.Custom;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f633c7db68e508b9dc59af971d555c72fd2aae8f", @"/Views/Tickets/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2889cc5cc431ba8747eb733b332e56d1a70baf04", @"/Views/_ViewImports.cshtml")]
    public class Views_Tickets_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Model.DB_Model.Ticket>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Tickets\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(133, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(162, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5afc416999e4764b723a213afcdc854", async() => {
                BeginContext(185, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(199, 65, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n\t\t<tr>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(265, 49, false);
#line 17 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Tickets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Numero_Ticket));

#line default
#line hidden
            EndContext();
            BeginContext(314, 25, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(340, 45, false);
#line 20 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Tickets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Prioridad));

#line default
#line hidden
            EndContext();
            BeginContext(385, 25, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(411, 41, false);
#line 23 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Tickets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Fecha));

#line default
#line hidden
            EndContext();
            BeginContext(452, 21, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n");
            EndContext();
            BeginContext(529, 51, true);
            WriteLiteral("\t\t\t\t<label>Usuario</label>\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(581, 51, false);
#line 30 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Tickets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombre_completo));

#line default
#line hidden
            EndContext();
            BeginContext(632, 25, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(658, 46, false);
#line 33 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Tickets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Asignado_A));

#line default
#line hidden
            EndContext();
            BeginContext(704, 25, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(730, 45, false);
#line 36 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Tickets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Incidente));

#line default
#line hidden
            EndContext();
            BeginContext(775, 25, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
            EndContext();
            BeginContext(801, 42, false);
#line 39 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Tickets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(843, 62, true);
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th></th>\r\n\t\t</tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 45 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Tickets\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(937, 21, true);
            WriteLiteral("\t\t<tr>\r\n\t\t\t<td>\r\n\t\t\t\t");
            EndContext();
            BeginContext(959, 48, false);
#line 48 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Tickets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Numero_Ticket));

#line default
#line hidden
            EndContext();
            BeginContext(1007, 25, true);
            WriteLiteral("\r\n\t\t\t</td>\r\n\t\t\t<td>\r\n\t\t\t\t");
            EndContext();
            BeginContext(1033, 44, false);
#line 51 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Tickets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Prioridad));

#line default
#line hidden
            EndContext();
            BeginContext(1077, 25, true);
            WriteLiteral("\r\n\t\t\t</td>\r\n\t\t\t<td>\r\n\t\t\t\t");
            EndContext();
            BeginContext(1103, 40, false);
#line 54 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Tickets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Fecha));

#line default
#line hidden
            EndContext();
            BeginContext(1143, 25, true);
            WriteLiteral("\r\n\t\t\t</td>\r\n\t\t\t<td>\r\n\t\t\t\t");
            EndContext();
            BeginContext(1169, 45, false);
#line 57 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Tickets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Usuario_Id));

#line default
#line hidden
            EndContext();
            BeginContext(1214, 25, true);
            WriteLiteral("\r\n\t\t\t</td>\r\n\t\t\t<td>\r\n\t\t\t\t");
            EndContext();
            BeginContext(1240, 50, false);
#line 60 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Tickets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nombre_completo));

#line default
#line hidden
            EndContext();
            BeginContext(1290, 27, true);
            WriteLiteral("\r\n\t\t\t</td>\r\n\r\n\t\t\t<td>\r\n\t\t\t\t");
            EndContext();
            BeginContext(1318, 45, false);
#line 64 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Tickets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Asignado_A));

#line default
#line hidden
            EndContext();
            BeginContext(1363, 25, true);
            WriteLiteral("\r\n\t\t\t</td>\r\n\t\t\t<td>\r\n\t\t\t\t");
            EndContext();
            BeginContext(1389, 44, false);
#line 67 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Tickets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Incidente));

#line default
#line hidden
            EndContext();
            BeginContext(1433, 30, true);
            WriteLiteral("\r\n\t\t\t</td>\r\n\t\t\t\r\n\t\t\t<td>\r\n\t\t\t\t");
            EndContext();
            BeginContext(1464, 41, false);
#line 71 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Tickets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1505, 25, true);
            WriteLiteral("\r\n\t\t\t</td>\r\n\t\t\t<td>\r\n\t\t\t\t");
            EndContext();
            BeginContext(1530, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5245837adfe4c4d8a6b4dca2de545d9", async() => {
                BeginContext(1575, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 74 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Tickets\Index.cshtml"
                                       WriteLiteral(item.Id);

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
            BeginContext(1583, 8, true);
            WriteLiteral(" |\r\n\t\t\t\t");
            EndContext();
            BeginContext(1591, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5331cbeb9dac4f53af538bc836d5e625", async() => {
                BeginContext(1639, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 75 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Tickets\Index.cshtml"
                                          WriteLiteral(item.Id);

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
            BeginContext(1650, 8, true);
            WriteLiteral(" |\r\n\t\t\t\t");
            EndContext();
            BeginContext(1658, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6941dd174ec435f87c4b07da4a182ad", async() => {
                BeginContext(1705, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 76 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Tickets\Index.cshtml"
                                         WriteLiteral(item.Id);

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
            BeginContext(1715, 21, true);
            WriteLiteral("\r\n\t\t\t</td>\r\n\t\t</tr>\r\n");
            EndContext();
#line 79 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Tickets\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1739, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Model.DB_Model.Ticket>> Html { get; private set; }
    }
}
#pragma warning restore 1591
