#pragma checksum "C:\Users\Savochek\RiderProjects\SchoolDiary3\SchoolDiary3\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "facec01cd0c309bb56d71b73a5a98d73d889ba18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Savochek\RiderProjects\SchoolDiary3\SchoolDiary3\Views\_ViewImports.cshtml"
using SchoolDiary3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Savochek\RiderProjects\SchoolDiary3\SchoolDiary3\Views\_ViewImports.cshtml"
using SchoolDiary3.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Savochek\RiderProjects\SchoolDiary3\SchoolDiary3\Views\Home\Index.cshtml"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Savochek\RiderProjects\SchoolDiary3\SchoolDiary3\Views\Home\Index.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Savochek\RiderProjects\SchoolDiary3\SchoolDiary3\Views\Home\Index.cshtml"
using SchoolDiary3.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"facec01cd0c309bb56d71b73a5a98d73d889ba18", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6d2fdd8979af13cd32665ea146f166b365b0658", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Savochek\RiderProjects\SchoolDiary3\SchoolDiary3\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    CultureInfo.CurrentCulture = CultureInfo.CurrentUICulture = new CultureInfo("ru");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">");
#nullable restore
#line 11 "C:\Users\Savochek\RiderProjects\SchoolDiary3\SchoolDiary3\Views\Home\Index.cshtml"
                     Write(Resources.Welcome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n    <p>Current UI Culture: ");
#nullable restore
#line 13 "C:\Users\Savochek\RiderProjects\SchoolDiary3\SchoolDiary3\Views\Home\Index.cshtml"
                      Write(TempData["Culture"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(", thread\'s UI culture: ");
#nullable restore
#line 13 "C:\Users\Savochek\RiderProjects\SchoolDiary3\SchoolDiary3\Views\Home\Index.cshtml"
                                                                  Write(Thread.CurrentThread.CurrentUICulture.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Current UI thread\'s managed ID: ");
#nullable restore
#line 14 "C:\Users\Savochek\RiderProjects\SchoolDiary3\SchoolDiary3\Views\Home\Index.cshtml"
                                   Write(Thread.CurrentThread.ManagedThreadId);

#line default
#line hidden
#nullable disable
            WriteLiteral(", controller\'s thread\'s managed ID: ");
#nullable restore
#line 14 "C:\Users\Savochek\RiderProjects\SchoolDiary3\SchoolDiary3\Views\Home\Index.cshtml"
                                                                                                              Write(TempData["ThreadID"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Action arguments keys: ");
#nullable restore
#line 15 "C:\Users\Savochek\RiderProjects\SchoolDiary3\SchoolDiary3\Views\Home\Index.cshtml"
                          Write(string.Join(", ", Context.Request.QueryString));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>");
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
