#pragma checksum "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Account\ResetPassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4225b25e3c7abc96198ebfaee994ac711e8352e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ResetPassword), @"mvc.1.0.view", @"/Views/Account/ResetPassword.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/ResetPassword.cshtml", typeof(AspNetCore.Views_Account_ResetPassword))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4225b25e3c7abc96198ebfaee994ac711e8352e1", @"/Views/Account/ResetPassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2889cc5cc431ba8747eb733b332e56d1a70baf04", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ResetPassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ResetPasswordViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Account\ResetPassword.cshtml"
  
    ViewBag.Title = "Reset password";

#line default
#line hidden
            BeginContext(77, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(84, 13, false);
#line 6 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Account\ResetPassword.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(97, 10, true);
            WriteLiteral(".</h2>\r\n\r\n");
            EndContext();
#line 8 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Account\ResetPassword.cshtml"
 using (Html.BeginForm("ResetPassword", "Account", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
{
    

#line default
#line hidden
            BeginContext(236, 23, false);
#line 10 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Account\ResetPassword.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(261, 47, true);
            WriteLiteral("    <h4>Reset your password.</h4>\r\n    <hr />\r\n");
            EndContext();
            BeginContext(313, 58, false);
#line 13 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Account\ResetPassword.cshtml"
Write(Html.ValidationSummary("", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(378, 35, false);
#line 14 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Account\ResetPassword.cshtml"
Write(Html.HiddenFor(model => model.Code));

#line default
#line hidden
            EndContext();
            BeginContext(415, 38, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(454, 70, false);
#line 16 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Account\ResetPassword.cshtml"
   Write(Html.LabelFor(m => m.Email, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(524, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(572, 62, false);
#line 18 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Account\ResetPassword.cshtml"
       Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(634, 68, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(703, 73, false);
#line 22 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Account\ResetPassword.cshtml"
   Write(Html.LabelFor(m => m.Password, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(776, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(824, 66, false);
#line 24 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Account\ResetPassword.cshtml"
       Write(Html.PasswordFor(m => m.Password, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(890, 68, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(959, 80, false);
#line 28 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Account\ResetPassword.cshtml"
   Write(Html.LabelFor(m => m.ConfirmPassword, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1039, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(1087, 73, false);
#line 30 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Account\ResetPassword.cshtml"
       Write(Html.PasswordFor(m => m.ConfirmPassword, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1160, 212, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" class=\"btn btn-default\" value=\"Reset\" />\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 38 "D:\Users\Administrador\source\repos\WebTicket\WebTickets\Views\Account\ResetPassword.cshtml"
}

#line default
#line hidden
            BeginContext(1375, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1395, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResetPasswordViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
