#pragma checksum "C:\Users\Kyle\Documents\school\cis174\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Shared\_StudentAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c274c0b900e34ee050dc122644c32d90e4c7079"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c274c0b900e34ee050dc122644c32d90e4c7079", @"/Views/Shared/_StudentAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"960e6ccb98a3b872e69da610e4c5b003252b85b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__StudentAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CIS174_TestCoreApp.Models.StudentModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 92, true);
            WriteLiteral("<!--This is the partial view for admin access \n    levels. This one shows grades. \n    -->\n\n");
            EndContext();
            BeginContext(138, 19, true);
            WriteLiteral("\n<p>\n    Name: <em>");
            EndContext();
            BeginContext(158, 15, false);
#line 8 "C:\Users\Kyle\Documents\school\cis174\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Shared\_StudentAdmin.cshtml"
         Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(173, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(175, 14, false);
#line 8 "C:\Users\Kyle\Documents\school\cis174\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Shared\_StudentAdmin.cshtml"
                          Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(189, 31, true);
            WriteLiteral("</em>  --- \n    Grade: <strong>");
            EndContext();
            BeginContext(221, 11, false);
#line 9 "C:\Users\Kyle\Documents\school\cis174\Assignment_5_1_StarterCode\CIS174_TestCoreApp\Views\Shared\_StudentAdmin.cshtml"
              Write(Model.Grade);

#line default
#line hidden
            EndContext();
            BeginContext(232, 14, true);
            WriteLiteral("</strong>\n</p>");
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