#pragma checksum "C:\Users\Morteza\Desktop\my-projects\afagh\Views\Shared\_FileInfoLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f61ba50e854b38466c3c5f05c25392019e97fee2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__FileInfoLayout), @"mvc.1.0.view", @"/Views/Shared/_FileInfoLayout.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Morteza\Desktop\my-projects\afagh\Views\_ViewImports.cshtml"
using my_projects;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Morteza\Desktop\my-projects\afagh\Views\_ViewImports.cshtml"
using my_projects.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f61ba50e854b38466c3c5f05c25392019e97fee2", @"/Views/Shared/_FileInfoLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2aa3fd29936d3dfd0edd66c6dba90206b25b043", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__FileInfoLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Morteza\Desktop\my-projects\afagh\Views\Shared\_FileInfoLayout.cshtml"
  
	ViewBag.Title = "Index";
	Layout = "~/Views/Shared/_MasterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row "">
	<div class=""col-2 border-left p-0"">
		<div class=""text-center p-4 border-bottom"">
			<div class=""m-4"">
				<i class=""fa fa-5x fa-user-circle-o"" aria-hidden=""true""></i>
			</div>
			<div class=""mt-2 mb-2""> <button type=""button"" class=""btn btn-info"">
					<i class=""fa fa-print"" aria-hidden=""true""></i>
					<span class=""fs-s""> چاپ اطلاعات پرونده</span>

				</button>
			</div>
			<div class=""fs-s align-right mt-1 "">
				<span class=""px-2"">نام کاربر</span>
				<span>مرتضی بیگدلی</span>
			</div>
			<div class=""fs-s align-right mt-1 mb-4"">
				<span class="" px-2"">شماره نظام</span>
				<span>2575548</span>
			</div>


		</div>
		<div class=""list-group list-group-flush align-right"">
			<a class=""list-group-item list-group-item-action list-group-item-light"" href=""#!"">
				<i class=""fa fa-chevron-left"" aria-hidden=""true""></i>
				پروفایل</a>
			<a class=""list-group-item list-group-item-action list-group-item-light"" href=""#!"">
				<i class=""fa fa-chevron-left"" aria-hi");
            WriteLiteral(@"dden=""true""></i>
				تاریخچه ضرایب موثر</a>
			<a class=""list-group-item list-group-item-action list-group-item-light"" href=""#!"">
				<i class=""fa fa-chevron-left"" aria-hidden=""true""></i>
				پروانه اشتغال</a>
			<a class=""list-group-item list-group-item-action list-group-item-light"" id=""DisabledCredentials"" href=""#!"">
				<i class=""fa fa-chevron-left"" aria-hidden=""true""></i>
				غیر فعالی صلاحیت ها</a>
			<a class=""list-group-item list-group-item-action list-group-item-light"" href=""#!"">
				<i class=""fa fa-chevron-left"" aria-hidden=""true""></i>
				احکام انتظامی</a>

		</div>
	</div>
	<div class=""col-10"" style=""display:block;"">
		");
#nullable restore
#line 50 "C:\Users\Morteza\Desktop\my-projects\afagh\Views\Shared\_FileInfoLayout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t</div>\r\n</div>\r\n");
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
