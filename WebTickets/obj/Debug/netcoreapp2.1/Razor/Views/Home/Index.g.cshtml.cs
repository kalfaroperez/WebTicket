#pragma checksum "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "431da315030a41a795aa87f4f6bf8d538f0d4080"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 7 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\_ViewImports.cshtml"
using WebTickets.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"431da315030a41a795aa87f4f6bf8d538f0d4080", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c713a1b51c4402ae1ef8a5d9b2ef8c6e67fa362", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Users\kalfaro\source\repos\kalfaroperez\webticket\WebTickets\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 1577, true);
            WriteLiteral(@"
<div class=""row"">
	<div class=""col-md-4"">
		<div class=""card card-chart"">
			<div class=""card-header card-header-success"">
				<div class=""ct-chart"" id=""dailySalesChart""></div>
			</div>
			<div class=""card-body"">
				<h4 class=""card-title"">Daily Sales</h4>
				<p class=""card-category"">
					<span class=""text-success""><i class=""fa fa-long-arrow-up""></i> 55% </span> increase in today sales.
				</p>
			</div>
			<div class=""card-footer"">
				<div class=""stats"">
					<i class=""material-icons"">access_time</i> updated 4 minutes ago
				</div>
			</div>
		</div>
	</div>
	<div class=""col-md-4"">
		<div class=""card card-chart"">
			<div class=""card-header card-header-warning"">
				<div class=""ct-chart"" id=""""></div>
			</div>
			<div class=""card-body"">
				<h4 class=""card-title"">Email Subscriptions</h4>
				<p class=""card-category"">Last Campaign Performance</p>
			</div>
			<div class=""card-footer"">
				<div class=""stats"">
					<i class=""material-icons"">access_time</i> campaign sent 2 da");
            WriteLiteral(@"ys ago
				</div>
			</div>
		</div>
	</div>
	<div class=""col-md-4"">
		<div class=""card card-chart"">
			<div class=""card-header card-header-danger"">
				<div class=""ct-chart"" id=""completedTasksChart""></div>
			</div>
			<div class=""card-body"">
				<h4 class=""card-title"">Completed Tasks</h4>
				<p class=""card-category"">Last Campaign Performance</p>
			</div>
			<div class=""card-footer"">
				<div class=""stats"">
					<i class=""material-icons"">access_time</i> campaign sent 2 days ago
				</div>
			</div>
		</div>
	</div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
