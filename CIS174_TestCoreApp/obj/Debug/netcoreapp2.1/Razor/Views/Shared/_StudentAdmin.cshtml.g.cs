#pragma checksum "C:\Users\Kyle\Documents\school\cis174\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Shared\_StudentAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f625d0030d19784f70a13bb324948b59b510c9b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__StudentAdmin), @"mvc.1.0.view", @"/Views/Shared/_StudentAdmin.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_StudentAdmin.cshtml", typeof(AspNetCore.Views_Shared__StudentAdmin))]
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
#line 1 "C:\Users\Kyle\Documents\school\cis174\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\_ViewImports.cshtml"
using CIS174_TestCoreApp;

#line default
#line hidden
#line 2 "C:\Users\Kyle\Documents\school\cis174\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\_ViewImports.cshtml"
using CIS174_TestCoreApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f625d0030d19784f70a13bb324948b59b510c9b6", @"/Views/Shared/_StudentAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b0c89835ffd0a30fcde2417f863d02f1a9e8dc4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__StudentAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CIS174_TestCoreApp.Models.StudentModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 96, true);
            WriteLiteral("<!--This is the partial view for admin access \r\n    levels. This one shows grades. \r\n    -->\r\n\r\n");
            EndContext();
            BeginContext(143, 21, true);
            WriteLiteral("\r\n<p>\r\n    Name: <em>");
            EndContext();
            BeginContext(165, 15, false);
#line 8 "C:\Users\Kyle\Documents\school\cis174\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Shared\_StudentAdmin.cshtml"
         Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(180, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(182, 14, false);
#line 8 "C:\Users\Kyle\Documents\school\cis174\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Shared\_StudentAdmin.cshtml"
                          Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(196, 32, true);
            WriteLiteral("</em>  --- \r\n    Grade: <strong>");
            EndContext();
            BeginContext(229, 11, false);
#line 9 "C:\Users\Kyle\Documents\school\cis174\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Shared\_StudentAdmin.cshtml"
              Write(Model.Grade);

#line default
#line hidden
            EndContext();
            BeginContext(240, 15, true);
            WriteLiteral("</strong>\r\n</p>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CIS174_TestCoreApp.Models.StudentModel> Html { get; private set; }
    }
}
#pragma warning restore 1591