#pragma checksum "C:\Users\Morteza\Desktop\my-projects\afagh\Views\FinancInfo\StepPayments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6938b86459faaf6692b87b16e3698f281574684f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FinancInfo_StepPayments), @"mvc.1.0.view", @"/Views/FinancInfo/StepPayments.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6938b86459faaf6692b87b16e3698f281574684f", @"/Views/FinancInfo/StepPayments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2aa3fd29936d3dfd0edd66c6dba90206b25b043", @"/Views/_ViewImports.cshtml")]
    public class Views_FinancInfo_StepPayments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<my_projects.Models.StepPaymentsViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Morteza\Desktop\my-projects\afagh\Views\FinancInfo\StepPayments.cshtml"
  
	ViewData["Title"] = "گزارش سوابق مالی";
	

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
	<h5 class=""align-right fs-s font-weight-bold mb-3""> گزارش  پرداخت های مرحله ای</h5>

	<table id=""tbGrid"" class=""table hover text-center fs-es mt-3"">
		<thead>
			<tr>
				<th scope=""col""> ردیف</th>
				<th scope=""col"">عنوان فرایند</th>
				<th scope=""col"">وضعیت فرایند </th>
				<th scope=""col"">کد فرایند </th>
				<th scope=""col""> نام مالک </th>
				<th scope=""col"">پلاک ثبتی</th>
				<th scope=""col"">عنوان مرحله</th>
				<th scope=""col"">تاریخ پرداخت</th>
				<th scope=""col"">پرداخت شده</th>
				<th scope=""col"">عملیات</th>

			</tr>
		</thead>
		<tbody");
            BeginWriteAttribute("id", " id=\"", 688, "\"", 693, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 26 "C:\Users\Morteza\Desktop\my-projects\afagh\Views\FinancInfo\StepPayments.cshtml"
              
				foreach (var item in Model)
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 30 "C:\Users\Morteza\Desktop\my-projects\afagh\Views\FinancInfo\StepPayments.cshtml"
                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 31 "C:\Users\Morteza\Desktop\my-projects\afagh\Views\FinancInfo\StepPayments.cshtml"
                       Write(item.ProcessTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 32 "C:\Users\Morteza\Desktop\my-projects\afagh\Views\FinancInfo\StepPayments.cshtml"
                       Write(item.ProcessState);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 33 "C:\Users\Morteza\Desktop\my-projects\afagh\Views\FinancInfo\StepPayments.cshtml"
                       Write(item.ProcessId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 34 "C:\Users\Morteza\Desktop\my-projects\afagh\Views\FinancInfo\StepPayments.cshtml"
                       Write(item.OwnerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 35 "C:\Users\Morteza\Desktop\my-projects\afagh\Views\FinancInfo\StepPayments.cshtml"
                       Write(item.Plate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 36 "C:\Users\Morteza\Desktop\my-projects\afagh\Views\FinancInfo\StepPayments.cshtml"
                       Write(item.StepTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 37 "C:\Users\Morteza\Desktop\my-projects\afagh\Views\FinancInfo\StepPayments.cshtml"
                       Write(item.PaymentDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 38 "C:\Users\Morteza\Desktop\my-projects\afagh\Views\FinancInfo\StepPayments.cshtml"
                       Write(item.Amountpaid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td><a><i class=\"fa fa-folder-open text-primary pointer\" aria-hidden=\"true\"></i></a></td>\r\n\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 41 "C:\Users\Morteza\Desktop\my-projects\afagh\Views\FinancInfo\StepPayments.cshtml"
				}
			

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</tbody>\r\n\t</table>\r\n</div>\r\n");
#nullable restore
#line 47 "C:\Users\Morteza\Desktop\my-projects\afagh\Views\FinancInfo\StepPayments.cshtml"
Write(await Html.PartialAsync("~/Views/Scripts/_GridScripts.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<my_projects.Models.StepPaymentsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
