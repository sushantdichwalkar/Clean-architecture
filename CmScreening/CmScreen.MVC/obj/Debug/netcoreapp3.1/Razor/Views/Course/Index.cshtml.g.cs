#pragma checksum "D:\Dropbox (eClerx Services Ltd.)\Projects\Clean Architecture_CMS\CmScreening\CmScreen.MVC\Views\Course\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0f8cbe57bd08db7a4c93435ebaf30beb12f5ee2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Index), @"mvc.1.0.view", @"/Views/Course/Index.cshtml")]
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
#line 1 "D:\Dropbox (eClerx Services Ltd.)\Projects\Clean Architecture_CMS\CmScreening\CmScreen.MVC\Views\_ViewImports.cshtml"
using CmScreen.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Dropbox (eClerx Services Ltd.)\Projects\Clean Architecture_CMS\CmScreening\CmScreen.MVC\Views\_ViewImports.cshtml"
using CmScreen.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0f8cbe57bd08db7a4c93435ebaf30beb12f5ee2", @"/Views/Course/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edc340aefa764a95305fb0a5ddb583bc9e7ab344", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CmScreen.Application.ViewModels.CourseViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"container body-content\">\n    <div class=\"row course-content\">\n");
#nullable restore
#line 5 "D:\Dropbox (eClerx Services Ltd.)\Projects\Clean Architecture_CMS\CmScreening\CmScreen.MVC\Views\Course\Index.cshtml"
         foreach (var course in Model.Courses)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"course-image-container\">\n                <div class=\"course-image\"");
            BeginWriteAttribute("style", " style=\"", 277, "\"", 323, 3);
            WriteAttributeValue("", 285, "background-image:url(", 285, 21, true);
#nullable restore
#line 8 "D:\Dropbox (eClerx Services Ltd.)\Projects\Clean Architecture_CMS\CmScreening\CmScreen.MVC\Views\Course\Index.cshtml"
WriteAttributeValue("", 306, course.ImageUrl, 306, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 322, ")", 322, 1, true);
            EndWriteAttribute();
            WriteLiteral("></div>\n            </div>\n");
            WriteLiteral("            <span>");
#nullable restore
#line 11 "D:\Dropbox (eClerx Services Ltd.)\Projects\Clean Architecture_CMS\CmScreening\CmScreen.MVC\Views\Course\Index.cshtml"
             Write(course.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 12 "D:\Dropbox (eClerx Services Ltd.)\Projects\Clean Architecture_CMS\CmScreening\CmScreen.MVC\Views\Course\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CmScreen.Application.ViewModels.CourseViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
