#pragma checksum "C:\Users\Morteza\Desktop\my-projects\afagh\Views\FileInfo\DisabledCredentials.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6835fee4b4b6c785161445c057adbfcab453b7aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FileInfo_DisabledCredentials), @"mvc.1.0.view", @"/Views/FileInfo/DisabledCredentials.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6835fee4b4b6c785161445c057adbfcab453b7aa", @"/Views/FileInfo/DisabledCredentials.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2aa3fd29936d3dfd0edd66c6dba90206b25b043", @"/Views/_ViewImports.cshtml")]
    public class Views_FileInfo_DisabledCredentials : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""card"">
	<div class=""card-body"">
		<div id=""dataGrid""></div>
	</div>
</div>
    <script type=""text/javascript""> 

        $(document).ready(function () {
		
		$(""#dataGrid"").dxDataGrid({
			
			dataSource: ""/FileInfo/getDisabledCredentials"",
			        paging: {
            pageSize: 10
        },
		showBorders:true,

			        columns: [{
            dataField: ""StartDate"",
			caption:""?????????? ????????"",

        }, {
            dataField: ""EndDate"",
			caption:""?????????? ??????????"",

        }, {
            dataField: ""OrganizationalField"", 
            caption:""???????? ??????????????"",

        }, {
            dataField: ""TypeOfCompetence"", 
            caption:""?????? ????????????"",

        },
		 {
            dataField: ""ShareAndWork"",
            caption:""??????"",


        },
		 {
            dataField: ""DateOfRegistration"",
            caption:""?????????? ??????"",


        },
		 {
            dataField: ""Description"",
            caption:""??????????"",


        },
		],
			
		
		");
            WriteLiteral("});\r\n\r\n        });\r\n \r\n   </script>\r\n\r\n\r\n");
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
