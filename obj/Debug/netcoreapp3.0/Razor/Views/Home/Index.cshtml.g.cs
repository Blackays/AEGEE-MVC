#pragma checksum "C:\Users\mni01\source\repos\AEGEE-MVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2a15ca95fcf40192dc3ec0fecad629c56343c35"
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
#line 1 "C:\Users\mni01\source\repos\AEGEE-MVC\Views\_ViewImports.cshtml"
using AEGEE_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mni01\source\repos\AEGEE-MVC\Views\_ViewImports.cshtml"
using AEGEE_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2a15ca95fcf40192dc3ec0fecad629c56343c35", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6046309c0fb538af540f612e07d9ced0d65b4d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mni01\source\repos\AEGEE-MVC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <div class=\"text-center\">\n        <h1 class=\"display-4\">Welcome ");
#nullable restore
#line 7 "C:\Users\mni01\source\repos\AEGEE-MVC\Views\Home\Index.cshtml"
                                 Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n");
#nullable restore
#line 8 "C:\Users\mni01\source\repos\AEGEE-MVC\Views\Home\Index.cshtml"
         foreach (var claim in User.Claims.ToList())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>");
#nullable restore
#line 10 "C:\Users\mni01\source\repos\AEGEE-MVC\Views\Home\Index.cshtml"
          Write(claim.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 10 "C:\Users\mni01\source\repos\AEGEE-MVC\Views\Home\Index.cshtml"
                        Write(claim.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 11 "C:\Users\mni01\source\repos\AEGEE-MVC\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\n    </div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
