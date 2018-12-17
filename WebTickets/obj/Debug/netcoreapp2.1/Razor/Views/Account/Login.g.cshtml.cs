#pragma checksum "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c5d48545bdafb07b49b5e6028f3f39103a05118"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Login.cshtml", typeof(AspNetCore.Views_Account_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c5d48545bdafb07b49b5e6028f3f39103a05118", @"/Views/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2889cc5cc431ba8747eb733b332e56d1a70baf04", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/login_principal.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Real S.A."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Login.cshtml"
  
    ViewBag.Title = "Ingreso al sistema";

#line default
#line hidden
            BeginContext(73, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(80, 13, false);
#line 6 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Login.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(93, 83, true);
            WriteLiteral(".</h2>\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n\t\t<section id=\"loginForm\">\r\n");
            EndContext();
#line 10 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Login.cshtml"
             using (Html.BeginForm("Login", "Account", new { ReturnUrl = ViewBag.ReturnUrl }, FormMethod.Post, true, new { @class = "form-horizontal", role = "form" }))
			{
				

#line default
#line hidden
            BeginContext(348, 23, false);
#line 12 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Login.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(373, 61, true);
            WriteLiteral("\t\t\t\t<h4>Acceso a la Herramienta de Tickets</h4>\r\n\t\t\t\t<hr />\r\n");
            EndContext();
            BeginContext(439, 64, false);
#line 15 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Login.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(511, 31, true);
            WriteLiteral("\t\t\t\t\t<div class=\"form-group\">\r\n");
            EndContext();
            BeginContext(627, 99, true);
            WriteLiteral("\t\t\t\t\t\t<label class=\"col-md-4 control-label\"> Usuario</label>\r\n\t\t\t\t\t\t<div class=\"col-md-8\">\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(727, 65, false);
#line 21 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Login.cshtml"
                       Write(Html.TextBoxFor(m => m.UserName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(792, 9, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(802, 78, false);
#line 22 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Login.cshtml"
                       Write(Html.ValidationMessageFor(m => m.UserName, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(880, 60, true);
            WriteLiteral("\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"form-group\">\r\n");
            EndContext();
            BeginContext(1025, 102, true);
            WriteLiteral("\t\t\t\t\t\t<label class=\"col-md-4 control-label\"> Contraseña</label>\r\n\t\t\t\t\t\t<div class=\"col-md-8\">\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1128, 66, false);
#line 29 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Login.cshtml"
                       Write(Html.PasswordFor(m => m.Password, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1194, 9, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1204, 78, false);
#line 30 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Login.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1282, 145, true);
            WriteLiteral("\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t<div class=\"col-md-offset-4 col-md-8\">\r\n\t\t\t\t\t\t\t<div class=\"checkbox\">\r\n\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1428, 35, false);
#line 36 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Login.cshtml"
                           Write(Html.CheckBoxFor(m => m.RememberMe));

#line default
#line hidden
            EndContext();
            BeginContext(1463, 10, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(1474, 32, false);
#line 37 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Login.cshtml"
                           Write(Html.LabelFor(m => m.RememberMe));

#line default
#line hidden
            EndContext();
            BeginContext(1506, 44, true);
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
            EndContext();
            BeginContext(1562, 184, true);
            WriteLiteral("\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t<div class=\"col-md-offset-4 col-md-8\">\r\n\t\t\t\t\t\t<input type=\"submit\" value=\"Log in\" class=\"btn btn-default\" />\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t<p>\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(1747, 56, false);
#line 49 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Login.cshtml"
               Write(Html.ActionLink("Registre un nuevo usuario", "Register"));

#line default
#line hidden
            EndContext();
            BeginContext(1803, 12, true);
            WriteLiteral("\r\n\t\t\t\t</p>\r\n");
            EndContext();
#line 54 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Login.cshtml"
                  
			}

#line default
#line hidden
            BeginContext(2001, 88, true);
            WriteLiteral("\t\t</section>\r\n    </div>\r\n\t<div class=\"col-md-8\">\r\n\t\t<!--Imagen Logo-->\r\n\t\t<center>\r\n\t\t\t");
            EndContext();
            BeginContext(2089, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c169c9d6509c47c5bd653339185c2577", async() => {
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
            EndContext();
            BeginContext(2147, 36, true);
            WriteLiteral("\r\n\t\t</center>\r\n\r\n\t</div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2201, 8, true);
                WriteLiteral("\r\n    \r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591