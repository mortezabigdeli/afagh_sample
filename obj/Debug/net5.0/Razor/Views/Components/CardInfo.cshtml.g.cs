#pragma checksum "C:\Users\Morteza\Desktop\my-projects\afagh\Views\Components\CardInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63974e598cf8ae53c29e9295fcea922b765f1923"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Components_CardInfo), @"mvc.1.0.view", @"/Views/Components/CardInfo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63974e598cf8ae53c29e9295fcea922b765f1923", @"/Views/Components/CardInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2aa3fd29936d3dfd0edd66c6dba90206b25b043", @"/Views/_ViewImports.cshtml")]
    public class Views_Components_CardInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dictionary<List<ProfileSectionViewModel>,string[]>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Morteza\Desktop\my-projects\afagh\Views\Components\CardInfo.cshtml"
    List<ProfileSectionViewModel> _model= new  List<ProfileSectionViewModel>();
    string[] cardInfo={};
  foreach (KeyValuePair<List<ProfileSectionViewModel>, string[]> data in Model)  
    {  
       _model=data.Key;
       cardInfo= data.Value;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  \r\n<div class=\"container\">\r\n\t<div class=\"card mt-4 outer-shadow\">\r\n\t\t<div class=\"card-body\">\r\n        <div class=\"row align-right\">\r\n          <div");
            BeginWriteAttribute("class", " class=\"", 480, "\"", 529, 4);
            WriteAttributeValue("", 488, "col-auto", 488, 8, true);
            WriteAttributeValue(" ", 496, "border-bottom", 497, 14, true);
#nullable restore
#line 17 "C:\Users\Morteza\Desktop\my-projects\afagh\Views\Components\CardInfo.cshtml"
WriteAttributeValue(" ", 510, cardInfo[1], 511, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("  ", 523, "mx-3", 525, 6, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
            WriteLiteral(" <i");
            BeginWriteAttribute("class", " class=\"", 547, "\"", 567, 1);
#nullable restore
#line 18 "C:\Users\Morteza\Desktop\my-projects\afagh\Views\Components\CardInfo.cshtml"
WriteAttributeValue("", 555, cardInfo[0], 555, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n");
#nullable restore
#line 19 "C:\Users\Morteza\Desktop\my-projects\afagh\Views\Components\CardInfo.cshtml"
       Write(cardInfo[2]);

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n          <div class=\"col border-bottom  ml-4\">&nbsp</div>\r\n          </div>\r\n\t\t\t<div class=\"grid-container\">\r\n\r\n");
#nullable restore
#line 26 "C:\Users\Morteza\Desktop\my-projects\afagh\Views\Components\CardInfo.cshtml"
        
          foreach(var item in _model)
          {


#line default
#line hidden
#nullable disable
            WriteLiteral("             <div class=\"grid-item\">\r\n               <div class=\"text-muted pb-1\">");
#nullable restore
#line 31 "C:\Users\Morteza\Desktop\my-projects\afagh\Views\Components\CardInfo.cshtml"
                                       Write(item.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n               <div class=\"font-weight-bold pt-1\">");
#nullable restore
#line 32 "C:\Users\Morteza\Desktop\my-projects\afagh\Views\Components\CardInfo.cshtml"
                                             Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n             </div>\r\n");
#nullable restore
#line 34 "C:\Users\Morteza\Desktop\my-projects\afagh\Views\Components\CardInfo.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n      </div>\r\n\t\t</div>\r\n\t</div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dictionary<List<ProfileSectionViewModel>,string[]>> Html { get; private set; }
    }
}
#pragma warning restore 1591
