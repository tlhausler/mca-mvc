#pragma checksum "C:\Users\tambe\Desktop\School\semester4\portfolio\MVCTitle45MCA\Views\Home\Part.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa77bd14774d144ca1ce6f3fcf9f232f5c1c1116"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Part), @"mvc.1.0.view", @"/Views/Home/Part.cshtml")]
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
#line 1 "C:\Users\tambe\Desktop\School\semester4\portfolio\MVCTitle45MCA\Views\_ViewImports.cshtml"
using MVCTitle45MCA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tambe\Desktop\School\semester4\portfolio\MVCTitle45MCA\Views\_ViewImports.cshtml"
using MVCTitle45MCA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa77bd14774d144ca1ce6f3fcf9f232f5c1c1116", @"/Views/Home/Part.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"505aedbf055be84e8ec36745def4e2fccda920df", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Part : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVCTitle45MCA.ViewModels.Title45ViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\tambe\Desktop\School\semester4\portfolio\MVCTitle45MCA\Views\Home\Part.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm\">\r\n\r\n        </div>\r\n        <div class=\"col-sm\">\r\n");
#nullable restore
#line 13 "C:\Users\tambe\Desktop\School\semester4\portfolio\MVCTitle45MCA\Views\Home\Part.cshtml"
             using (Html.BeginForm("Section", "Home"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>\r\n                    ");
#nullable restore
#line 16 "C:\Users\tambe\Desktop\School\semester4\portfolio\MVCTitle45MCA\Views\Home\Part.cshtml"
               Write(Html.DropDownListFor(m => m.SelectedPart, new SelectList(Model.SelectListPart, "Value", "Text"), "Select Part"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <input type=\"submit\" value=\"submit\" />\r\n");
#nullable restore
#line 19 "C:\Users\tambe\Desktop\School\semester4\portfolio\MVCTitle45MCA\Views\Home\Part.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"col-sm\">\r\n\r\n        </div>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVCTitle45MCA.ViewModels.Title45ViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
