#pragma checksum "C:\Users\Morteza\Desktop\my-projects\afagh\Views\Scripts\_GridScripts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27390df1345b0718f9e9a27b6658df3937484a25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Scripts__GridScripts), @"mvc.1.0.view", @"/Views/Scripts/_GridScripts.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27390df1345b0718f9e9a27b6658df3937484a25", @"/Views/Scripts/_GridScripts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2aa3fd29936d3dfd0edd66c6dba90206b25b043", @"/Views/_ViewImports.cshtml")]
    public class Views_Scripts__GridScripts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"	 <script>     
	$(document).ready(function () {        
	   gridDataTableView(""Grid Example.xls"");        
	});  
	 
	gridDataTableView = function (fname) {  
		$('#tbGrid').dataTable({  
			""language"": {
			""infoFiltered"":   """",
			 ""emptyTable"":     ""هیچ داده ای برای نمایش وجود ندارد"",
			""infoEmpty"":      """",
	""loadingRecords"": ""لطفا صبر کنید..."",
	""processing"":     ""در حال پردازش..."",
	""zeroRecords"":    ""یافت نشد"",
			""info"": ""_PAGE_ از _PAGES_"",
			""search"": ""جستجو "",
				""paginate"": {
		""first"":      ""ابتدا"",
		""last"":       ""انتها"",
		""next"":       ""بعدی"",
		""previous"":   ""قبلی""
	},
		},
			
			""pageLength"": 4,
			""bFilter"": true,  
			""bLengthChange"": false, ""bPaginate"": true, ""bInfo"": true,  
			dom: 'Bfrtip',              
			""order"": [[0, 'desc'], [1, 'desc']],  
		 
		});  
	}  
</script>  ");
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