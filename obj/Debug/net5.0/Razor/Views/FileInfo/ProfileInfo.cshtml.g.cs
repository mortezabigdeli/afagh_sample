#pragma checksum "C:\Users\Morteza\Desktop\my-projects\afagh\Views\FileInfo\ProfileInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e96f45b4794c5273efc03f0ae0517b1296fcc55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FileInfo_ProfileInfo), @"mvc.1.0.view", @"/Views/FileInfo/ProfileInfo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e96f45b4794c5273efc03f0ae0517b1296fcc55", @"/Views/FileInfo/ProfileInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2aa3fd29936d3dfd0edd66c6dba90206b25b043", @"/Views/_ViewImports.cshtml")]
    public class Views_FileInfo_ProfileInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<my_projects.Models.ProfileVewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Morteza\Desktop\my-projects\afagh\Views\FileInfo\ProfileInfo.cshtml"
	var spec=new Dictionary<List<ProfileSectionViewModel>,string[]>();
	var address=new Dictionary<List<ProfileSectionViewModel>,string[]>();
	var office=new Dictionary<List<ProfileSectionViewModel>,string[]>();
		
	string[] cardInfo ={"fa fa-lg fa-address-card-o text-primary","border-primary","مشخصات"};
	string[] Address ={"fa fa-lg fa-home text-warning", "border-warning","اطلاعات محل سکونت و محل اشتغال"};
	string[] Office ={"fa fa-lg fa-shopping-bag text-info", "border-info","دفتر مهندسی جاری"};

	spec.Add(Model.Specs,cardInfo);
	address.Add(Model.Address,Address);
	office.Add(Model.Office,Office);


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n\t\t\t");
#nullable restore
#line 19 "C:\Users\Morteza\Desktop\my-projects\afagh\Views\FileInfo\ProfileInfo.cshtml"
       Write(await Html.PartialAsync("~/Views/Components/CardInfo.cshtml",spec));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t<div class=\"d-flex flex-wrap\">\r\n");
#nullable restore
#line 22 "C:\Users\Morteza\Desktop\my-projects\afagh\Views\FileInfo\ProfileInfo.cshtml"
                     foreach (var item in Model.Info)
					{
						

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Morteza\Desktop\my-projects\afagh\Views\FileInfo\ProfileInfo.cshtml"
                   Write(await Html.PartialAsync("~/Views/Components/IconInfo.cshtml",item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Morteza\Desktop\my-projects\afagh\Views\FileInfo\ProfileInfo.cshtml"
                                                                                           

					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</div>\r\n\t\t\t");
#nullable restore
#line 29 "C:\Users\Morteza\Desktop\my-projects\afagh\Views\FileInfo\ProfileInfo.cshtml"
       Write(await Html.PartialAsync("~/Views/Components/CardInfo.cshtml",address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t");
#nullable restore
#line 30 "C:\Users\Morteza\Desktop\my-projects\afagh\Views\FileInfo\ProfileInfo.cshtml"
       Write(await Html.PartialAsync("~/Views/Components/CardInfo.cshtml",office));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<my_projects.Models.ProfileVewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
