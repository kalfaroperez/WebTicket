#pragma checksum "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Shared\_LoginPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3455a266027891a5860b443400f9786a69fa1eef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LoginPartial), @"mvc.1.0.view", @"/Views/Shared/_LoginPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_LoginPartial.cshtml", typeof(AspNetCore.Views_Shared__LoginPartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3455a266027891a5860b443400f9786a69fa1eef", @"/Views/Shared/_LoginPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c713a1b51c4402ae1ef8a5d9b2ef8c6e67fa362", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LoginPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("logoutForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(104, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Shared\_LoginPartial.cshtml"
 if (SignInManager.IsSignedIn(User))
{

#line default
#line hidden
            BeginContext(147, 1803, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "871bd796b472482792c76d736f05c498", async() => {
                BeginContext(324, 1619, true);
                WriteLiteral(@"
	
	<ul class=""navbar-nav"">
		<li class=""nav-item"">
			<a class=""nav-link"" href=""#pablo"">
				<i class=""material-icons"">dashboard</i>
				<p class=""d-lg-none d-md-block"">
					Stats
				</p>
			</a>
		</li>
		<li class=""nav-item dropdown"">
			<a class=""nav-link"" href=""http://example.com"" id=""navbarDropdownMenuLink"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
				<i class=""material-icons"">notifications</i>
				<span class=""notification"">5</span>
				<p class=""d-lg-none d-md-block"">
					Some Actions
				</p>
			</a>
			<div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""navbarDropdownMenuLink"">
				<a class=""dropdown-item"" href=""#"">Mike John responded to your email</a>
				<a class=""dropdown-item"" href=""#"">You have 5 new tasks</a>
				<a class=""dropdown-item"" href=""#"">You're now friend with Andrew</a>
				<a class=""dropdown-item"" href=""#"">Another Notification</a>
				<a class=""dropdown-item"" href=""#"">Another One</a>
			</div>
		</li>
		<li class=""na");
                WriteLiteral(@"v-item dropdown"">
			<a class=""nav-link"" href=""#pablo"" id=""navbarDropdownProfile"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
				<i class=""material-icons"">person</i>
				<p class=""d-lg-none d-md-block"">
					Account
				</p>
			</a>
			<div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""navbarDropdownProfile"">
				<a class=""dropdown-item"" href=""#"">Profile</a>
				<a class=""dropdown-item"" href=""#"">Settings</a>
				<div class=""dropdown-divider""></div>
				<button class=""dropdown-item"" type=""submit"">Log out</button>
			</div>
		</li>
	</ul>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 6 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Shared\_LoginPartial.cshtml"
                                                              WriteLiteral(Url.Action("Login", "Account", new { area = "" }));

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1950, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 49 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Shared\_LoginPartial.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1964, 49, true);
            WriteLiteral("\t<ul class=\"nav navbar-nav navbar-right\">\r\n\t\t<li>");
            EndContext();
            BeginContext(2014, 114, false);
#line 53 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Shared\_LoginPartial.cshtml"
       Write(Html.ActionLink("Register", "Register", "Account", routeValues: null, htmlAttributes: new { id = "registerLink" }));

#line default
#line hidden
            EndContext();
            BeginContext(2128, 13, true);
            WriteLiteral("</li>\r\n\t\t<li>");
            EndContext();
            BeginContext(2142, 106, false);
#line 54 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Shared\_LoginPartial.cshtml"
       Write(Html.ActionLink("Log in", "Login", "Account", routeValues: null, htmlAttributes: new { id = "loginLink" }));

#line default
#line hidden
            EndContext();
            BeginContext(2248, 15, true);
            WriteLiteral("</li>\r\n\t</ul>\r\n");
            EndContext();
#line 56 "C:\Users\KRAP-PC\Source\Repos\WebTicket\WebTickets\Views\Shared\_LoginPartial.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
