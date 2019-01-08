#pragma checksum "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c065da490f55fdb622f967e9aefe51ffdb7bb3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Register.cshtml", typeof(AspNetCore.Views_Account_Register))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c065da490f55fdb622f967e9aefe51ffdb7bb3a", @"/Views/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2889cc5cc431ba8747eb733b332e56d1a70baf04", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegisterViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Register.cshtml"
  
	ViewBag.Title = "Registro";

#line default
#line hidden
            BeginContext(63, 6, true);
            WriteLiteral("\r\n<h3>");
            EndContext();
            BeginContext(70, 13, false);
#line 6 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Register.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(83, 31, true);
            WriteLiteral(" - Crear nueva cuenta.</h3>\r\n\r\n");
            EndContext();
#line 8 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Register.cshtml"
 using (Html.BeginForm("Register", "Account", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
{
	

#line default
#line hidden
            BeginContext(235, 23, false);
#line 10 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Register.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(263, 9, true);
            WriteLiteral("\t<hr />\r\n");
            EndContext();
            BeginContext(274, 58, false);
#line 13 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Register.cshtml"
Write(Html.ValidationSummary("", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(334, 29, true);
            WriteLiteral("\t<div class=\"form-group\">\r\n\t\t");
            EndContext();
            BeginContext(364, 73, false);
#line 15 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Register.cshtml"
   Write(Html.LabelFor(m => m.FullName, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(437, 31, true);
            WriteLiteral("\r\n\t\t<div class=\"col-md-4\">\r\n\t\t\t");
            EndContext();
            BeginContext(469, 65, false);
#line 17 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Register.cshtml"
       Write(Html.TextBoxFor(m => m.FullName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(534, 5, true);
            WriteLiteral("\r\n\t\t\t");
            EndContext();
            BeginContext(539, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2993807b21dd44c79abbd98364a5a37f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 18 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Register.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FullName);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(602, 50, true);
            WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n\t<div class=\"form-group\">\r\n\t\t");
            EndContext();
            BeginContext(653, 70, false);
#line 22 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Register.cshtml"
   Write(Html.LabelFor(m => m.Email, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(723, 31, true);
            WriteLiteral("\r\n\t\t<div class=\"col-md-4\">\r\n\t\t\t");
            EndContext();
            BeginContext(755, 62, false);
#line 24 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Register.cshtml"
       Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(817, 5, true);
            WriteLiteral("\r\n\t\t\t");
            EndContext();
            BeginContext(822, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f65bc542d5148c6928dcf7195bf78af", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 25 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Register.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Email);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(882, 50, true);
            WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n\t<div class=\"form-group\">\r\n\t\t");
            EndContext();
            BeginContext(933, 69, false);
#line 29 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Register.cshtml"
   Write(Html.LabelFor(m => m.Area, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1002, 31, true);
            WriteLiteral("\r\n\t\t<div class=\"col-md-4\">\r\n\t\t\t");
            EndContext();
            BeginContext(1033, 119, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5403210241df4cb39e53c78c2bda2e40", async() => {
                BeginContext(1102, 6, true);
                WriteLiteral("\r\n\t\t\t\t");
                EndContext();
                BeginContext(1108, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "224a444c7f844af4b8a224c3c2eee758", async() => {
                    BeginContext(1116, 13, true);
                    WriteLiteral("Seleccione...");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1138, 5, true);
                WriteLiteral("\r\n\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 31 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Register.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Area);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 31 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Register.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.Areas;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1152, 121, true);
            WriteLiteral("\r\n\t\t\t<!--<span asp-validation-for=\"Area\" class=\"text-danger\"></span>-->\r\n\t\t</div>\r\n\t</div>\r\n\t<div class=\"form-group\">\r\n\t\t");
            EndContext();
            BeginContext(1274, 74, false);
#line 38 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Register.cshtml"
   Write(Html.LabelFor(m => m.Ubicacion, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1348, 31, true);
            WriteLiteral("\r\n\t\t<div class=\"col-md-4\">\r\n\t\t\t");
            EndContext();
            BeginContext(1380, 66, false);
#line 40 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Register.cshtml"
       Write(Html.TextBoxFor(m => m.Ubicacion, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1446, 50, true);
            WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n\t<div class=\"form-group\">\r\n\t\t");
            EndContext();
            BeginContext(1497, 73, false);
#line 44 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Register.cshtml"
   Write(Html.LabelFor(m => m.Telefono, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1570, 31, true);
            WriteLiteral("\r\n\t\t<div class=\"col-md-4\">\r\n\t\t\t");
            EndContext();
            BeginContext(1602, 65, false);
#line 46 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Register.cshtml"
       Write(Html.TextBoxFor(m => m.Telefono, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1667, 59, true);
            WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n\t<hr />\r\n\t<div class=\"form-group\">\r\n\t\t");
            EndContext();
            BeginContext(1727, 73, false);
#line 51 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Register.cshtml"
   Write(Html.LabelFor(m => m.UserName, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1800, 31, true);
            WriteLiteral("\r\n\t\t<div class=\"col-md-4\">\r\n\t\t\t");
            EndContext();
            BeginContext(1832, 65, false);
#line 53 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Register.cshtml"
       Write(Html.TextBoxFor(m => m.UserName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1897, 5, true);
            WriteLiteral("\r\n\t\t\t");
            EndContext();
            BeginContext(1902, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a09612dc59674226b0401ff3dd4dd217", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 54 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Register.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserName);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1965, 50, true);
            WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n\t<div class=\"form-group\">\r\n\t\t");
            EndContext();
            BeginContext(2016, 73, false);
#line 58 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Register.cshtml"
   Write(Html.LabelFor(m => m.Password, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(2089, 31, true);
            WriteLiteral("\r\n\t\t<div class=\"col-md-4\">\r\n\t\t\t");
            EndContext();
            BeginContext(2121, 66, false);
#line 60 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Register.cshtml"
       Write(Html.PasswordFor(m => m.Password, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2187, 5, true);
            WriteLiteral("\r\n\t\t\t");
            EndContext();
            BeginContext(2192, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cecc5078c36c4ab8879891a1aabaaa64", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 61 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Register.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Password);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2255, 50, true);
            WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n\t<div class=\"form-group\">\r\n\t\t");
            EndContext();
            BeginContext(2306, 80, false);
#line 65 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Register.cshtml"
   Write(Html.LabelFor(m => m.ConfirmPassword, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(2386, 31, true);
            WriteLiteral("\r\n\t\t<div class=\"col-md-4\">\r\n\t\t\t");
            EndContext();
            BeginContext(2418, 73, false);
#line 67 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Register.cshtml"
       Write(Html.PasswordFor(m => m.ConfirmPassword, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2491, 5, true);
            WriteLiteral("\r\n\t\t\t");
            EndContext();
            BeginContext(2496, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2999ab1a9af8479e8714b720e6095f07", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 68 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Register.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ConfirmPassword);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2566, 179, true);
            WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n\t<div class=\"form-group\">\r\n\t\t<div class=\"col-md-offset-2 col-md-10\">\r\n\t\t\t<input type=\"submit\" class=\"btn btn-default\" value=\"Register\" />\r\n\t\t</div>\r\n\t</div>\r\n");
            EndContext();
#line 76 "D:\Users\Administrador\source\repos\Ticket\WebTickets\Views\Account\Register.cshtml"
}

#line default
#line hidden
            BeginContext(2748, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2768, 4, true);
                WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
